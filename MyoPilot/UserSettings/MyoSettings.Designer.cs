﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyoPilot.UserSettings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class MyoSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MyoSettings defaultInstance = ((MyoSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MyoSettings())));
        
        public static MyoSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        public double rollDeathzone {
            get {
                return ((double)(this["rollDeathzone"]));
            }
            set {
                this["rollDeathzone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        public double pitchDeathzone {
            get {
                return ((double)(this["pitchDeathzone"]));
            }
            set {
                this["pitchDeathzone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        public double yawDeathzone {
            get {
                return ((double)(this["yawDeathzone"]));
            }
            set {
                this["yawDeathzone"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double rollMax {
            get {
                return ((double)(this["rollMax"]));
            }
            set {
                this["rollMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double pitchMax {
            get {
                return ((double)(this["pitchMax"]));
            }
            set {
                this["pitchMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double yawMax {
            get {
                return ((double)(this["yawMax"]));
            }
            set {
                this["yawMax"] = value;
            }
        }
    }
}