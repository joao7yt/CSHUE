﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSHUE.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunOnStartup {
            get {
                return ((bool)(this["RunOnStartup"]));
            }
            set {
                this["RunOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Activated {
            get {
                return ((bool)(this["Activated"]));
            }
            set {
                this["Activated"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double Top {
            get {
                return ((double)(this["Top"]));
            }
            set {
                this["Top"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double Left {
            get {
                return ((double)(this["Left"]));
            }
            set {
                this["Left"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("450")]
        public double Height {
            get {
                return ((double)(this["Height"]));
            }
            set {
                this["Height"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("650")]
        public double Width {
            get {
                return ((double)(this["Width"]));
            }
            set {
                this["Width"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Maximized {
            get {
                return ((bool)(this["Maximized"]));
            }
            set {
                this["Maximized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty MainMenu {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["MainMenu"]));
            }
            set {
                this["MainMenu"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty TerroristsWin {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["TerroristsWin"]));
            }
            set {
                this["TerroristsWin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty CounterTerroristsWin {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["CounterTerroristsWin"]));
            }
            set {
                this["CounterTerroristsWin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty RoundStarts {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["RoundStarts"]));
            }
            set {
                this["RoundStarts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty BombPlanted {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["BombPlanted"]));
            }
            set {
                this["BombPlanted"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventProperty PlayerGetsFlashed {
            get {
                return ((global::CSHUE.Helpers.EventProperty)(this["PlayerGetsFlashed"]));
            }
            set {
                this["PlayerGetsFlashed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty BombExplodes {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["BombExplodes"]));
            }
            set {
                this["BombExplodes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty BombBlink {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["BombBlink"]));
            }
            set {
                this["BombBlink"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty FreezeTime {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["FreezeTime"]));
            }
            set {
                this["FreezeTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty Warmup {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["Warmup"]));
            }
            set {
                this["Warmup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty PlayerGetsKill {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["PlayerGetsKill"]));
            }
            set {
                this["PlayerGetsKill"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::CSHUE.Helpers.EventBrightnessProperty PlayerGetsKilled {
            get {
                return ((global::CSHUE.Helpers.EventBrightnessProperty)(this["PlayerGetsKilled"]));
            }
            set {
                this["PlayerGetsKilled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.5")]
        public decimal PlayerGetsKillDuration {
            get {
                return ((decimal)(this["PlayerGetsKillDuration"]));
            }
            set {
                this["PlayerGetsKillDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public decimal PlayerGetsKilledDuration {
            get {
                return ((decimal)(this["PlayerGetsKilledDuration"]));
            }
            set {
                this["PlayerGetsKilledDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RunOnStartupMinimized {
            get {
                return ((bool)(this["RunOnStartupMinimized"]));
            }
            set {
                this["RunOnStartupMinimized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizeToSystemTray {
            get {
                return ((bool)(this["MinimizeToSystemTray"]));
            }
            set {
                this["MinimizeToSystemTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoMinimize {
            get {
                return ((bool)(this["AutoMinimize"]));
            }
            set {
                this["AutoMinimize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public byte CsgoCheckingPeriod {
            get {
                return ((byte)(this["CsgoCheckingPeriod"]));
            }
            set {
                this["CsgoCheckingPeriod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TriggerSpecEvents {
            get {
                return ((bool)(this["TriggerSpecEvents"]));
            }
            set {
                this["TriggerSpecEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RememberLightsStates {
            get {
                return ((bool)(this["RememberLightsStates"]));
            }
            set {
                this["RememberLightsStates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoActivate {
            get {
                return ((bool)(this["AutoActivate"]));
            }
            set {
                this["AutoActivate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("18:00")]
        public string AutoActivateStart {
            get {
                return ((string)(this["AutoActivateStart"]));
            }
            set {
                this["AutoActivateStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("06:00")]
        public string AutoActivateEnd {
            get {
                return ((string)(this["AutoActivateEnd"]));
            }
            set {
                this["AutoActivateEnd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunCsgo {
            get {
                return ((bool)(this["RunCsgo"]));
            }
            set {
                this["RunCsgo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LaunchOptions {
            get {
                return ((string)(this["LaunchOptions"]));
            }
            set {
                this["LaunchOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int Language {
            get {
                return ((int)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CsgoFolder {
            get {
                return ((string)(this["CsgoFolder"]));
            }
            set {
                this["CsgoFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SteamFolder {
            get {
                return ((string)(this["SteamFolder"]));
            }
            set {
                this["SteamFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AppKey {
            get {
                return ((string)(this["AppKey"]));
            }
            set {
                this["AppKey"] = value;
            }
        }
    }
}
