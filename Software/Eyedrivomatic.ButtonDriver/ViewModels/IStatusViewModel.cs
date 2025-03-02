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


using System.Windows;
using Eyedrivomatic.ButtonDriver.Hardware.Services;
using Eyedrivomatic.Hardware.Communications;

namespace Eyedrivomatic.ButtonDriver.ViewModels
{
    public interface IStatusViewModel
    {
        ConnectionState ConnectionState { get; }
        Point JoystickPosition { get; }
        Direction CurrentDirection { get; }
        string Profile { get; }
        ReadyState ReadyState { get; }
        bool SafetyBypassStatus { get; }
        string Speed { get; }

        bool Switch1 { get; }
        bool Switch2 { get; }
        bool Switch3 { get; }
    }

    class DesignStatusViewModel : IStatusViewModel
    {
        public ConnectionState ConnectionState => ConnectionState.Connecting;
        public Point JoystickPosition => new Point(7, 12);
        public Direction CurrentDirection => Direction.BackwardRight;
        public string Profile => "Indoors";
        public ReadyState ReadyState => ReadyState.Continue;
        public bool SafetyBypassStatus => false;
        public string Speed => "Walk";
        public bool Switch1 => false;
        public bool Switch2 => true;
        public bool Switch3 => false;
    }
}