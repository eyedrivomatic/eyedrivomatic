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
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using Eyedrivomatic.Logging;

namespace Eyedrivomatic.Hardware.Services
{
    [MessageProcessor("Log")]
    [PartCreationPolicy(CreationPolicy.Shared)]
    internal class LogMessageProcessor : LineMessageProcessor
    {
        public const string MessagePrefix = "LOG:";
        private readonly Regex _messageFormat = new Regex($@"^{MessagePrefix} (?<Severity>.*) - (?<Message>.*)$");

        private void Process(string message)
        {
            var match = _messageFormat.Match(message);
            if (!match.Success)
            {
                Log.Warn(this, $"Unable to parse log entry - '{message}'.");
                return;
            }

            var categoryMap = new Dictionary<string, Action<string>>
            {
                { "DEBUG", msg => Log.Debug(this, msg) },
                { "INFO", msg => Log.Info(this, msg) },
                { "WARN", msg => Log.Warn(this, msg) },
                { "ERROR", msg => Log.Error(this, msg) },
            };

            var logAction = 
                match.Groups["Severity"].Success && categoryMap.ContainsKey(match.Groups["Severity"].Value)
                    ? categoryMap[match.Groups["Severity"].Value]
                    : categoryMap["ERROR"];

            logAction(match.Groups["Message"].Value);
        }

        protected override IDisposable Attach(IObservable<string> source, IObserver<string> sink)
        {
            return source.Where(message => message.StartsWith(MessagePrefix)).Subscribe(Process);
        }
    }
}
