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

namespace Eyedrivomatic.Hardware.Commands
{
    internal class MoveCommand : DeviceCommandBase
    {
        internal MoveCommand(int xPositionRelative, int yPositionRelative, TimeSpan duration)
        {
            XPositionRelative = xPositionRelative;
            YPositionRelative = yPositionRelative;
            Duration = duration;
        }

        public int XPositionRelative { get; }
        public int YPositionRelative { get; }
        public TimeSpan Duration { get; }

        public override string Name => "Move";

        public override int MaxAttempts => 1; //Move only gets 1 try

        public override string ToString()
        {
            return $"MOVE {Duration.TotalMilliseconds} {XPositionRelative} {YPositionRelative}";
        }
    }
}