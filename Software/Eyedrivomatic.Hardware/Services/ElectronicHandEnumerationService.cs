﻿//	Copyright (c) 2018 Eyedrivomatic Authors
//	
//	This file is part of the 'Eyedrivomatic' PC application.
//	
//	This program is intended for use as part of the 'Eyedrivomatic System' for 
//	controlling an electric wheelchair using soley the user's eyes. 
//	
//	Eyedrivomaticis distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  


using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Eyedrivomatic.Hardware.Communications;
using Eyedrivomatic.Logging;
using NullGuard;
using Eyedrivomatic.Infrastructure.Extensions;

namespace Eyedrivomatic.Hardware.Services
{
    [Export(typeof(IDeviceEnumerationService))]
    public class ElectronicHandEnumerationService : IDeviceEnumerationService
    {
        private readonly IElectronicHandConnectionFactory _connectionFactory;
        private readonly IEnumerable<IElectronicHandDeviceInfo> _infos;

        [ImportingConstructor]
        public ElectronicHandEnumerationService(IElectronicHandConnectionFactory connectionFactory, [ImportMany] IEnumerable<IElectronicHandDeviceInfo> infos)
        {
            _connectionFactory = connectionFactory;
            _infos = infos;
        }

        [return: AllowNull]
        public async Task<IDeviceConnection> DetectDeviceAsync(Version minVersion, CancellationToken cancellationToken)
        {
            var devices = GetAvailableDevices(false);
            cancellationToken.ThrowIfCancellationRequested();

            var foundCts = new CancellationTokenSource();
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, foundCts.Token);

            var connections = from device in devices
                select _connectionFactory.CreateConnection(device);
            var connectionTasks = (from connection in connections
                select new Tuple<IDeviceConnection, Task>(connection, connection.ConnectAsync(cts.Token))).ToList();

            //See if there are any devices with the expected hardware ID's and version.
            var foundDevice = await DetectMinVersionDeviceAsync(minVersion, connectionTasks, cts.Token);
            if (foundDevice != null)
            {
                foundCts.Cancel();
                return foundDevice;
            }

            //Ok... let's see if there are any devices with an older firmware
            foundDevice = await DetectMinVersionDeviceAsync(null, connectionTasks, cts.Token);
            if (foundDevice != null)
            {
                foundCts.Cancel();
                return foundDevice;
            }


            //Maybe there is a device with an odd hardware ID (it happens).
            var otherDevices = GetAvailableDevices(true).Except(devices).ToList();
            cancellationToken.ThrowIfCancellationRequested();

            connections = from device in otherDevices
                          select _connectionFactory.CreateConnection(device);
            connectionTasks = (from connection in connections
                select new Tuple<IDeviceConnection, Task>(connection, connection.ConnectAsync(cts.Token))).ToList();

            //Is there one of these devices with a recent version of the firmware aboard?
            foundDevice = await DetectMinVersionDeviceAsync(minVersion, connectionTasks, cts.Token);
            if (foundDevice != null)
            {
                foundCts.Cancel();
                return foundDevice;
            }

            //OK, is there any serial port with any version of firmware that we can connect to?
            foundDevice = await DetectMinVersionDeviceAsync(null, connectionTasks, cts.Token);
            if (foundDevice != null)
            {
                foundCts.Cancel();
                return foundDevice;
            }

            foundCts.Cancel();

            //And last shot, is ther a SINGLE device with the expected hardware ID? This should be an off-the-shelf Arduino UNO.
            if (devices.Count == 1)
            {
                var device = devices.Single();
                foundDevice = _connectionFactory.CreateConnection(device);
                Log.Info(this, $"Found device on [{foundDevice.ConnectionString}] with no apparent firmware! This is the only connected device with the expected hardware id.");
                return foundDevice;
            }
            return null;
        }

        private async Task<IDeviceConnection> DetectMinVersionDeviceAsync(Version minVersion, IEnumerable<Tuple<IDeviceConnection, Task>> connectionTasks, CancellationToken cancellationToken)
        {
            var connectionTaskList = connectionTasks.ToList();

            while (connectionTaskList.Any())
            {
                await Task.WhenAny(connectionTaskList.Select(ct => ct.Item2).Union(new[] { cancellationToken.AsTask() }));
                cancellationToken.ThrowIfCancellationRequested();

                var connectionTask = connectionTaskList.First(ct => ct.Item2.IsCompleted);

                if (!connectionTask.Item2.IsFaulted && connectionTask.Item1.State == ConnectionState.Connected &&
                    (minVersion == null || minVersion <= connectionTask.Item1.VersionInfo?.Version))
                {
                    Log.Info(this, $"Found device on [{connectionTask.Item1.ConnectionString}] with firmware version [{connectionTask.Item1.VersionInfo}]!");
                    return connectionTask.Item1;
                }

                connectionTaskList.Remove(connectionTask);
            }

            return null;
        }

        public IList<DeviceDescriptor> GetAvailableDevices(bool includeAllSerialDevices)
        {
            var filter = includeAllSerialDevices ? null : _infos.SelectMany(i => i.EyedrivomaticIds.Values).Distinct().ToList();
            return UsbSerialDeviceEnumerator.EnumerateDevices(filter).GroupBy(i => i.ConnectionString).Select(g => g.First()) //groupby.select gets distinct connections.
                .OfType<DeviceDescriptor>().ToList();
        }
    }
}