﻿// Copyright (c) 2016 Eyedrivomatic Authors
//
// This file is part of the 'Eyedrivomatic' PC application.
//
//    This program is intended for use as part of the 'Eyedrivomatic System' for 
//    controlling an electric wheelchair using soley the user's eyes. 
//
//    Eyedrivomatic is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Eyedrivomatic is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Eyedrivomatic.  If not, see <http://www.gnu.org/licenses/>.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Input;

using Prism.Commands;
using Eyedrivomatic.ButtonDriver.Configuration;
using Eyedrivomatic.ButtonDriver.Hardware.Communications;
using Eyedrivomatic.ButtonDriver.Hardware.Models;
using Eyedrivomatic.ButtonDriver.Hardware.Services;
using Eyedrivomatic.Configuration;
using Eyedrivomatic.Infrastructure;
using Eyedrivomatic.Resources;
using NullGuard;

namespace Eyedrivomatic.ButtonDriver.ViewModels
{
    [Export]
    public class DeviceConfigturationViewModel : ButtonDriverViewModelBase, IHeaderInfoProvider<string>
    {
        private readonly IButtonDriverConfigurationService _configurationService;
        private readonly IDisposable _saveCommandRegistration;

        [ImportingConstructor]
        public DeviceConfigturationViewModel(
            IHardwareService hardwareService, 
            IButtonDriverConfigurationService configurationService,
            [Import(ConfigurationModule.SaveAllConfigurationCommandName)] CompositeCommand saveAllCommand)
            : base(hardwareService)
        {
            _configurationService = configurationService;
            _configurationService.PropertyChanged += ConfigurationService_PropertyChanged;

            RefreshAvailableDeviceListCommand = new DelegateCommand(RefreshAvailableDeviceList, CanRefreshAvailableDeviceList);
            AutoDetectDeviceCommand = new DelegateCommand(AutoDetectDevice, CanAutoDetectDevice);
            ConnectCommand = new DelegateCommand(Connect, CanConnect);
            DisconnectCommand = new DelegateCommand(Disconnect, CanDisconnect);
            TrimCommand = new DelegateCommand<Direction?>(Trim).ObservesCanExecute(() => Connected);

            RefreshAvailableDeviceList();

            _saveCommandRegistration = saveAllCommand.DisposableRegisterCommand(SaveCommand);
        }

        public string HeaderInfo => Strings.ViewName_DeviceConfig;

        public ICommand RefreshAvailableDeviceListCommand { get; }

        public DelegateCommand AutoDetectDeviceCommand { get; }
        public DelegateCommand ConnectCommand { get; }
        public DelegateCommand DisconnectCommand { get; }
        public DelegateCommand<Direction?> TrimCommand { get; } 

        public bool Connecting => Driver.Connection.State == ConnectionState.Connecting;
        public bool Connected => Driver.Connection.State == ConnectionState.Connected;
        public bool Ready => Driver.HardwareReady;
        
        public class SerialDeviceInfo
        {
            public readonly string Name;
            public readonly string Port;

            public SerialDeviceInfo(string name, string port)
            {
                Name = name;
                Port = port;
            }

            public override string ToString()
            {
                return $"{Port} - {Name}";
            }
        };

        private IList<SerialDeviceInfo> _availableDevices;
        public IList<SerialDeviceInfo> AvailableDevices
        {
            get => _availableDevices;
            set => SetProperty(ref _availableDevices, value);
        }

        [AllowNull]
        public SerialDeviceInfo SelectedDevice
        {
            get => AvailableDevices.FirstOrDefault(device => device.Port == _configurationService.ConnectionString); 
            set => _configurationService.ConnectionString = value?.Port ?? string.Empty;
        }

        public bool AutoConnect
        {
            get => _configurationService.AutoConnect;
            set => _configurationService.AutoConnect = value;
        }

        public void RefreshAvailableDeviceList()
        {
            AvailableDevices = (from dev in Driver?.Connection.GetAvailableDevices() orderby dev.Item2 select new SerialDeviceInfo(dev.Item1, dev.Item2)).ToList();

            ConnectCommand.RaiseCanExecuteChanged();
            DisconnectCommand.RaiseCanExecuteChanged();
            AutoDetectDeviceCommand.RaiseCanExecuteChanged();
        }

        public bool CanRefreshAvailableDeviceList()
        {
            return true;
        }

        protected async void AutoDetectDevice()
        {
            RefreshAvailableDeviceList();
            await Driver.Connection.AutoConnectAsync();
            SelectedDevice = AvailableDevices.FirstOrDefault(device => device.Port == Driver.Connection.ConnectionString);
        }

        protected bool CanAutoDetectDevice() { return !Connected && !Connecting; }

        protected async void Connect()
        {
            if (string.IsNullOrWhiteSpace(SelectedDevice?.Port)) throw new InvalidOperationException("Unable to connect - no device selected.");

            await Driver.Connection.ConnectAsync(SelectedDevice.Port);
        }

        protected bool CanConnect()
        {
            return SelectedDevice != null && !Connected && !Connecting;
        }

        protected void Disconnect()
        {
            Driver.Connection.Disconnect();
        }

        protected bool CanDisconnect()
        {
            return Connected;
        }

        public Point TrimPosition => Driver == null ? new Point(0, 0) : new Point(Driver.DeviceSettings.CenterPosX, Driver.DeviceSettings.CenterPosY);

        protected void Trim(Direction? direction)
        {
            if (!Connected || direction == null) return;

            var actionDictionary = new Dictionary<Direction, Action>
            {
                { Direction.Forward, () => Driver.DeviceSettings.CenterPosY++ },
                { Direction.Backward, () => Driver.DeviceSettings.CenterPosY-- },
                { Direction.Right, () => Driver.DeviceSettings.CenterPosX++ },
                { Direction.Left, () => Driver.DeviceSettings.CenterPosX-- }
            };

            if (!actionDictionary.ContainsKey(direction.Value)) return;
            actionDictionary[direction.Value]();
            HasChanges = true;
        }

        public int MaxLeft
        {
            get => (Driver?.DeviceSettings.IsKnown ?? false) ? -Driver.DeviceSettings.MinPosX : 0;
            set 
            {
                Driver.DeviceSettings.MinPosX = -value;
                HasChanges = true;
            }
        }

        public int MaxRight
        {
            get => (Driver?.DeviceSettings.IsKnown ?? false) ? Driver.DeviceSettings.MaxPosX : 0;
            set
            {
                Driver.DeviceSettings.MaxPosX = value;
                HasChanges = true;
            }
        }

        public int MaxBackward
        {
            get => (Driver?.DeviceSettings.IsKnown ?? false) ? -Driver.DeviceSettings.MinPosY : 0;
            set
            {
                Driver.DeviceSettings.MinPosY = -value;
                HasChanges = true;
            }
        }

        public int MaxForward
        {
            get => (Driver?.DeviceSettings.IsKnown ?? false) ? Driver.DeviceSettings.MaxPosY : 0;
            set
            {
                Driver.DeviceSettings.MaxPosY = value;
                HasChanges = true;
            }
        }

        private bool _deviceHasChanges;

        public bool HasChanges
        {
            get => _configurationService.HasChanges || _deviceHasChanges;
            private set
            {
                _deviceHasChanges = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveCommand => new DelegateCommand(Save).ObservesCanExecute(() => HasChanges);

        [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
        protected override void OnDriverStateChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnDriverStateChanged(sender, e);

            if (e.PropertyName == nameof(Driver.HardwareReady)) RaisePropertyChanged(nameof(Ready));

            if (e.PropertyName == nameof(Driver.Connection))
            {
                ConnectCommand.RaiseCanExecuteChanged();
                DisconnectCommand.RaiseCanExecuteChanged();
                AutoDetectDeviceCommand.RaiseCanExecuteChanged();
                TrimCommand.RaiseCanExecuteChanged();

                RaisePropertyChanged(nameof(Connecting));
                RaisePropertyChanged(nameof(Connected));
            }
        }

        [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
        protected override void OnDriverSettingsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IDeviceSettings.CenterPosX))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxLeft));
                RaisePropertyChanged(nameof(MaxRight));
            }
            else if (e.PropertyName == nameof(IDeviceSettings.CenterPosY))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxBackward));
                RaisePropertyChanged(nameof(MaxForward));
            }
            else if (e.PropertyName == nameof(IDeviceSettings.MinPosY))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxBackward));
            }
            else if (e.PropertyName == nameof(IDeviceSettings.MaxPosY))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxForward));
            }
            else if (e.PropertyName == nameof(IDeviceSettings.MinPosX))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxLeft));
            }
            else if (e.PropertyName == nameof(IDeviceSettings.MaxPosX))
            {
                RaisePropertyChanged(nameof(TrimPosition));
                RaisePropertyChanged(nameof(MaxRight));
            }
        }

        [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
        private void ConfigurationService_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            RaisePropertyChanged(string.Empty);

            ConnectCommand.RaiseCanExecuteChanged();
            DisconnectCommand.RaiseCanExecuteChanged();
            AutoDetectDeviceCommand.RaiseCanExecuteChanged();
        }

        private async void Save()
        {
            try
            {
                _configurationService.Save();
                await Driver.DeviceSettings.Save();
                HasChanges = false;
            }
            catch (Exception ex)
            {
                Log.Error(this, $"Failed to save device settings - [{ex}].");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _saveCommandRegistration?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
