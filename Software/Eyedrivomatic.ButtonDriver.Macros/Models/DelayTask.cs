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
using System.Threading.Tasks;
using System.Xml.Serialization;

using Eyedrivomatic.Resources;

namespace Eyedrivomatic.ButtonDriver.Macros.Models
{
    public class DelayTask : MacroTask, IMacroAsyncTask
    {
        [XmlAttribute("Time")]
        public double DelayMs { get; set; }

        public bool CanExecute()
        {
            return DelayMs > 0;
        }

        public Task ExecuteAsync()
        {
            return Task.Delay(TimeSpan.FromMilliseconds(DelayMs));
        }

        public override string ToString()
        {
            return string.Format(Strings.DelayTask_ToStringFormat, DelayMs/1000d);
        }

        #region IComparable
        public override bool Equals(MacroTask other)
        {
            var that = other as DelayTask;

            return that != null
                && this.DelayMs == that.DelayMs;
        }
        #endregion IComparable

        #region Validation

        protected override string[] ValidatedProperties => new[] { nameof(DelayMs) };

        protected override string GetValidationError(string propertyName)
        {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0) return null;

            switch (propertyName)
            {
                case nameof(DelayMs):
                    return ValidateDelayTime();
            }

            return base.GetValidationError(propertyName);
        }

        string ValidateDelayTime()
        {
            if (DelayMs <= 0) return string.Format(Strings.CycleRelayMacroTask_InvalidRelay, DelayMs);
            return null;
        }

        #endregion // Validation
    }
}
