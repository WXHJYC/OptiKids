﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JuliusSweetland.OptiKids.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Insert")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.Keys KeySelectionTriggerKeyboardKeyDownUpKey {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.Keys)(this["KeySelectionTriggerKeyboardKeyDownUpKey"]));
            }
            set {
                this["KeySelectionTriggerKeyboardKeyDownUpKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.MouseButtons KeySelectionTriggerMouseDownUpButton {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.MouseButtons)(this["KeySelectionTriggerMouseDownUpButton"]));
            }
            set {
                this["KeySelectionTriggerMouseDownUpButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fixations")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.TriggerSources KeySelectionTriggerSource {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.TriggerSources)(this["KeySelectionTriggerSource"]));
            }
            set {
                this["KeySelectionTriggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool SettingsUpgradeRequired {
            get {
                return ((bool)(this["SettingsUpgradeRequired"]));
            }
            set {
                this["SettingsUpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.1500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointTtl {
            get {
                return ((global::System.TimeSpan)(this["PointTtl"]));
            }
            set {
                this["PointTtl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6666")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int GazeTrackerUdpPort {
            get {
                return ((int)(this["GazeTrackerUdpPort"]));
            }
            set {
                this["GazeTrackerUdpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("75")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationVerticalFillPercentage {
            get {
                return ((int)(this["ToastNotificationVerticalFillPercentage"]));
            }
            set {
                this["ToastNotificationVerticalFillPercentage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.1")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public decimal ToastNotificationSecondsPerCharacter {
            get {
                return ((decimal)(this["ToastNotificationSecondsPerCharacter"]));
            }
            set {
                this["ToastNotificationSecondsPerCharacter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/Resources/Themes/Android_Dark.xaml")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string Theme {
            get {
                return ((string)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/Resources/Fonts/#Roboto")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontFamily {
            get {
                return ((string)(this["FontFamily"]));
            }
            set {
                this["FontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Condensed")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontStretch {
            get {
                return ((string)(this["FontStretch"]));
            }
            set {
                this["FontStretch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Light")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FontWeight {
            get {
                return ((string)(this["FontWeight"]));
            }
            set {
                this["FontWeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SpeechRate {
            get {
                return ((int)(this["SpeechRate"]));
            }
            set {
                this["SpeechRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string SpeechVoice {
            get {
                return ((string)(this["SpeechVoice"]));
            }
            set {
                this["SpeechVoice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SpeechVolume {
            get {
                return ((int)(this["SpeechVolume"]));
            }
            set {
                this["SpeechVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.7500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerIncompleteFixationTtl {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerIncompleteFixationTtl"]));
            }
            set {
                this["KeySelectionTriggerIncompleteFixationTtl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.2500000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerFixationLockOnTime {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerFixationLockOnTime"]));
            }
            set {
                this["KeySelectionTriggerFixationLockOnTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NextHigh")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string SelectionTriggerStopSignal {
            get {
                return ((string)(this["SelectionTriggerStopSignal"]));
            }
            set {
                this["SelectionTriggerStopSignal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("75")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ToastNotificationHorizontalFillPercentage {
            get {
                return ((int)(this["ToastNotificationHorizontalFillPercentage"]));
            }
            set {
                this["ToastNotificationHorizontalFillPercentage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FillPie")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.ProgressIndicatorBehaviours ProgressIndicatorBehaviour {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.ProgressIndicatorBehaviours)(this["ProgressIndicatorBehaviour"]));
            }
            set {
                this["ProgressIndicatorBehaviour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ProgressIndicatorResizeStartProportion {
            get {
                return ((int)(this["ProgressIndicatorResizeStartProportion"]));
            }
            set {
                this["ProgressIndicatorResizeStartProportion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ProgressIndicatorResizeEndProportion {
            get {
                return ((int)(this["ProgressIndicatorResizeEndProportion"]));
            }
            set {
                this["ProgressIndicatorResizeEndProportion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool KeySelectionTriggerFixationResumeRequiresLockOn {
            get {
                return ((bool)(this["KeySelectionTriggerFixationResumeRequiresLockOn"]));
            }
            set {
                this["KeySelectionTriggerFixationResumeRequiresLockOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Medium")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.DataStreamProcessingLevels TobiiEyeXProcessingLevel {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.DataStreamProcessingLevels)(this["TobiiEyeXProcessingLevel"]));
            }
            set {
                this["TobiiEyeXProcessingLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool Debug {
            get {
                return ((bool)(this["Debug"]));
            }
            set {
                this["Debug"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01.5000000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan KeySelectionTriggerFixationCompleteTime {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerFixationCompleteTime"]));
            }
            set {
                this["KeySelectionTriggerFixationCompleteTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MousePosition")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::JuliusSweetland.OptiKids.Enums.PointsSources PointsSource {
            get {
                return ((global::JuliusSweetland.OptiKids.Enums.PointsSources)(this["PointsSource"]));
            }
            set {
                this["PointsSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.0130000")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan PointsMousePositionSampleInterval {
            get {
                return ((global::System.TimeSpan)(this["PointsMousePositionSampleInterval"]));
            }
            set {
                this["PointsMousePositionSampleInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:03")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.TimeSpan TETCalibrationCheckTimeSpan {
            get {
                return ((global::System.TimeSpan)(this["TETCalibrationCheckTimeSpan"]));
            }
            set {
                this["TETCalibrationCheckTimeSpan"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Quizes\\DemoQuiz.json")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string QuizFile {
            get {
                return ((string)(this["QuizFile"]));
            }
            set {
                this["QuizFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-4")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int WordSpeechRate {
            get {
                return ((int)(this["WordSpeechRate"]));
            }
            set {
                this["WordSpeechRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-2")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SpellingSpeechRate {
            get {
                return ((int)(this["SpellingSpeechRate"]));
            }
            set {
                this["SpellingSpeechRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pronunciation\\EnglishUK.json")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string PronunciationFile {
            get {
                return ((string)(this["PronunciationFile"]));
            }
            set {
                this["PronunciationFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int MinImageDisplayTimeInSeconds {
            get {
                return ((int)(this["MinImageDisplayTimeInSeconds"]));
            }
            set {
                this["MinImageDisplayTimeInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int DelayBeforeProgressingInSeconds {
            get {
                return ((int)(this["DelayBeforeProgressingInSeconds"]));
            }
            set {
                this["DelayBeforeProgressingInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\Tone2.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string ErrorSoundFile {
            get {
                return ((string)(this["ErrorSoundFile"]));
            }
            set {
                this["ErrorSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int ErrorSoundVolume {
            get {
                return ((int)(this["ErrorSoundVolume"]));
            }
            set {
                this["ErrorSoundVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool PlayEncouragementOnCorrectlySpelledWord {
            get {
                return ((bool)(this["PlayEncouragementOnCorrectlySpelledWord"]));
            }
            set {
                this["PlayEncouragementOnCorrectlySpelledWord"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources\\Sounds\\Tone1.wav")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string InfoSoundFile {
            get {
                return ((string)(this["InfoSoundFile"]));
            }
            set {
                this["InfoSoundFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int InfoSoundVolume {
            get {
                return ((int)(this["InfoSoundVolume"]));
            }
            set {
                this["InfoSoundVolume"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool CheckForUpdates {
            get {
                return ((bool)(this["CheckForUpdates"]));
            }
            set {
                this["CheckForUpdates"] = value;
            }
        }
    }
}
