﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eyedrivomatic.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class AppearanceConfiguration : global::System.Configuration.ApplicationSettingsBase {
        
        private static AppearanceConfiguration defaultInstance = ((AppearanceConfiguration)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AppearanceConfiguration())));
        
        public static AppearanceConfiguration Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SettingsVersion {
            get {
                return ((int)(this["SettingsVersion"]));
            }
            set {
                this["SettingsVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Windows Default")]
        public string ThemeColors {
            get {
                return ((string)(this["ThemeColors"]));
            }
            set {
                this["ThemeColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3D Dark")]
        public string ThemeImages {
            get {
                return ((string)(this["ThemeImages"]));
            }
            set {
                this["ThemeImages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string ThemeStyles {
            get {
                return ((string)(this["ThemeStyles"]));
            }
            set {
                this["ThemeStyles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HideMouseCursor {
            get {
                return ((bool)(this["HideMouseCursor"]));
            }
            set {
                this["HideMouseCursor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CurrentCulture {
            get {
                return ((string)(this["CurrentCulture"]));
            }
            set {
                this["CurrentCulture"] = value;
            }
        }
    }
}
