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


using System.ComponentModel.Composition;
using Eyedrivomatic.ButtonDriver.Configuration;
using Eyedrivomatic.Logging;
using Prism.Mef.Modularity;
using Prism.Modularity;

namespace Eyedrivomatic.ButtonDriver.Hardware
{
    [ModuleExport(typeof(ButtonDriverHardwareModule), 
        InitializationMode = InitializationMode.WhenAvailable, 
        DependsOnModuleNames = new [] {nameof (ButtonDriverConfigurationModule)})]
    public class ButtonDriverHardwareModule : IModule
    {
        [ImportingConstructor]
        public ButtonDriverHardwareModule()
        {
            Log.Debug(this, $"Creating Module {nameof(ButtonDriverHardwareModule)}.");
        }

        public void Initialize()
        {
            Log.Debug(this, $"Initializing Module {nameof(ButtonDriverHardwareModule)}.");
        }
    }
}
