﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eyedrivomatic.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Eyedrivomatic.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Profile.
        /// </summary>
        public static string CommandText_AddProfile {
            get {
                return ResourceManager.GetString("CommandText_AddProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Speed.
        /// </summary>
        public static string CommandText_AddProfileSpeed {
            get {
                return ResourceManager.GetString("CommandText_AddProfileSpeed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatically Discover Device.
        /// </summary>
        public static string CommandText_AutoDiscover {
            get {
                return ResourceManager.GetString("CommandText_AutoDiscover", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        public static string CommandText_Cancel {
            get {
                return ResourceManager.GetString("CommandText_Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect.
        /// </summary>
        public static string CommandText_Connect {
            get {
                return ResourceManager.GetString("CommandText_Connect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue.
        /// </summary>
        public static string CommandText_Continue {
            get {
                return ResourceManager.GetString("CommandText_Continue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnect.
        /// </summary>
        public static string CommandText_Disconnect {
            get {
                return ResourceManager.GetString("CommandText_Disconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save.
        /// </summary>
        public static string CommandText_Save {
            get {
                return ResourceManager.GetString("CommandText_Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cycle Relay {0} on-off..
        /// </summary>
        public static string CycleRelayMacroTask_DefaultNameFormat {
            get {
                return ResourceManager.GetString("CycleRelayMacroTask_DefaultNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cycle a relay. This changes the state of the relay off-&gt;on-&gt;off with a 200ms delay..
        /// </summary>
        public static string CycleRelayMacroTask_Description {
            get {
                return ResourceManager.GetString("CycleRelayMacroTask_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be a value between 1 and {0}..
        /// </summary>
        public static string CycleRelayMacroTask_InvalidRelay {
            get {
                return ResourceManager.GetString("CycleRelayMacroTask_InvalidRelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be greater than 0..
        /// </summary>
        public static string CycleRelayMacroTask_InvalidRepeat {
            get {
                return ResourceManager.GetString("CycleRelayMacroTask_InvalidRepeat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cycle Relay {0}, repeat {1} times with a delay of {2} ms between repeats..
        /// </summary>
        public static string CycleRelayMacroTask_ToStringFormat {
            get {
                return ResourceManager.GetString("CycleRelayMacroTask_ToStringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delay {0:0.00}s.
        /// </summary>
        public static string DelayTask_DefaultNameFormat {
            get {
                return ResourceManager.GetString("DelayTask_DefaultNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delay must be greater than 0..
        /// </summary>
        public static string DelayTask_InvalidDelay {
            get {
                return ResourceManager.GetString("DelayTask_InvalidDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pause for {0:0.00} seconds..
        /// </summary>
        public static string DelayTask_ToStringFormat {
            get {
                return ResourceManager.GetString("DelayTask_ToStringFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device not found!.
        /// </summary>
        public static string DeviceConnection_Error_Auto_NotFound {
            get {
                return ResourceManager.GetString("DeviceConnection_Error_Auto_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to the device on &quot;{0}&quot;. The firmware version check failed..
        /// </summary>
        public static string DeviceConnection_Error_FirmwareCheck {
            get {
                return ResourceManager.GetString("DeviceConnection_Error_FirmwareCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection to the device on &quot;{0}&quot; failed..
        /// </summary>
        public static string DeviceConnection_Error_Manual {
            get {
                return ResourceManager.GetString("DeviceConnection_Error_Manual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device on &quot;{0}&quot; not found!.
        /// </summary>
        public static string DeviceConnection_Error_Manual_NotFound {
            get {
                return ResourceManager.GetString("DeviceConnection_Error_Manual_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device Connection Failed.
        /// </summary>
        public static string DeviceConnection_Error_Title {
            get {
                return ResourceManager.GetString("DeviceConnection_Error_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A device with an incompatable firmware version was found. However the firmware file installed with the application could not be found..
        /// </summary>
        public static string DeviceConnection_MinFirmwareNotAvailable {
            get {
                return ResourceManager.GetString("DeviceConnection_MinFirmwareNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I Understand and Agree.
        /// </summary>
        public static string Disclaimer_Button {
            get {
                return ResourceManager.GetString("Disclaimer_Button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Consolas;}{\f1\fnil\fcharset0 Calibri;}{\f2\fnil\fcharset2 Symbol;}}
        ///{\colortbl ;\red0\green0\blue0;}
        ///{\*\generator Riched20 10.0.15063}\viewkind4\uc1 
        ///\pard\qc\cf1\b\f0\fs44 DISCLAIMER\b0\par
        ///\par
        ///
        ///\pard\fs24 The Eyedrivomatic System is potentially dangerous if used without proper caution. No member of the Eyedrivomatic team accept any responsibility whatsoever for any injuries to persons, or damage to property sustained [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Disclaimer_Text {
            get {
                return ResourceManager.GetString("Disclaimer_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DISCLAIMER.
        /// </summary>
        public static string Disclaimer_Title {
            get {
                return ResourceManager.GetString("Disclaimer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Driving.
        /// </summary>
        public static string DriveProfile_Default {
            get {
                return ResourceManager.GetString("DriveProfile_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hallway.
        /// </summary>
        public static string DriveProfile_Hallway {
            get {
                return ResourceManager.GetString("DriveProfile_Hallway", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Large Room.
        /// </summary>
        public static string DriveProfile_LargeRoom {
            get {
                return ResourceManager.GetString("DriveProfile_LargeRoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Small Room.
        /// </summary>
        public static string DriveProfile_SmallRoom {
            get {
                return ResourceManager.GetString("DriveProfile_SmallRoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drive Speeds.
        /// </summary>
        public static string DrivingView_DriveSpeeds {
            get {
                return ResourceManager.GetString("DrivingView_DriveSpeeds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move Duration.
        /// </summary>
        public static string DrivingView_Duration {
            get {
                return ResourceManager.GetString("DrivingView_Duration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fast.
        /// </summary>
        public static string DrivingView_Speed_Fast {
            get {
                return ResourceManager.GetString("DrivingView_Speed_Fast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Slow.
        /// </summary>
        public static string DrivingView_Speed_Slow {
            get {
                return ResourceManager.GetString("DrivingView_Speed_Slow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Walk.
        /// </summary>
        public static string DrivingView_Speed_Walk {
            get {
                return ResourceManager.GetString("DrivingView_Speed_Walk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firmware Update.
        /// </summary>
        public static string Firmware_Update_Title {
            get {
                return ResourceManager.GetString("Firmware_Update_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current Version: {0}. Update Version: {1}.
        /// </summary>
        public static string Firmware_Update_Versions_Format {
            get {
                return ResourceManager.GetString("Firmware_Update_Versions_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A firmware update is available for the device on {0}. Would you like to update your device?
        ///Current Version: {1}
        ///Update Version: {2}
        ///.
        /// </summary>
        public static string Firmware_UpdateOptional_Directive_Format {
            get {
                return ResourceManager.GetString("Firmware_UpdateOptional_Directive_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firmware Update Available.
        /// </summary>
        public static string Firmware_UpdateOptional_Title {
            get {
                return ResourceManager.GetString("Firmware_UpdateOptional_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A device was detected on {0}, however the device has an older version of the Eyedrivomatic firmware. You must update the firmware to continue.
        ///    
        /// Current Version: {1}
        /// Update Version: {2}.
        /// </summary>
        public static string Firmware_UpdateRequired_Directive_Format {
            get {
                return ResourceManager.GetString("Firmware_UpdateRequired_Directive_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firmware Update Required.
        /// </summary>
        public static string Firmware_UpdateRequired_Title {
            get {
                return ResourceManager.GetString("Firmware_UpdateRequired_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Display Name. The cannot be empty or only whitespace characters..
        /// </summary>
        public static string Macro_InvalidDisplayName {
            get {
                return ResourceManager.GetString("Macro_InvalidDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Display Name. The cannot be empty or only whitespace characters..
        /// </summary>
        public static string MacroTask_InvalidDisplayName {
            get {
                return ResourceManager.GetString("MacroTask_InvalidDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to milliseconds.
        /// </summary>
        public static string MillisecondsLong {
            get {
                return ResourceManager.GetString("MillisecondsLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ms.
        /// </summary>
        public static string MillisecondsShort {
            get {
                return ResourceManager.GetString("MillisecondsShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Task.
        /// </summary>
        public static string NewTaskViewModelName {
            get {
                return ResourceManager.GetString("NewTaskViewModelName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drive.
        /// </summary>
        public static string ProfileName_Drive {
            get {
                return ResourceManager.GetString("ProfileName_Drive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Speed.
        /// </summary>
        public static string ProfileSpeed_Default {
            get {
                return ResourceManager.GetString("ProfileSpeed_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The left or right deflection when one of the diagonal buttons are pressed..
        /// </summary>
        public static string SettingDescripion_ProfileSpeed_XDiag {
            get {
                return ResourceManager.GetString("SettingDescripion_ProfileSpeed_XDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backward deflection when one of the forward diagonal buttons are pressed..
        /// </summary>
        public static string SettingDescripion_ProfileSpeed_YBackwardDiag {
            get {
                return ResourceManager.GetString("SettingDescripion_ProfileSpeed_YBackwardDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The forward deflection when one of the forward diagonal buttons are pressed..
        /// </summary>
        public static string SettingDescripion_ProfileSpeed_YForwardDiag {
            get {
                return ResourceManager.GetString("SettingDescripion_ProfileSpeed_YForwardDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the transparency of the driving buttons drawn over the forward-view camera image. Use 0 for fully transparent and 100 for fully opaque..
        /// </summary>
        public static string SettingDescription_CameraOverlayOpacity {
            get {
                return ResourceManager.GetString("SettingDescription_CameraOverlayOpacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These settings control the maximum distance that the &quot;Electronic Hand&quot; will move measured in degrees from the center. The maximum movement of the electric hand is 22 degrees in each direction. Be very careful not to exceed the physical limits of your joystick hardware!.
        /// </summary>
        public static string SettingDescription_DeviceLimits {
            get {
                return ResourceManager.GetString("SettingDescription_DeviceLimits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this to set the center-point for the &quot;Electronic Hand&quot; measured in degrees. 
        ///The center should be close to &quot;0,0&quot; and must be within the device limits specified above..
        /// </summary>
        public static string SettingDescription_DeviceTrim {
            get {
                return ResourceManager.GetString("SettingDescription_DeviceTrim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dwell time settings specify the time that a control should be selected before it activates. 
        ///Most controls will use the &quot;Standard&quot; time. However there are special controls that should have shorter or longer dwell times for safety or convenience. 
        ///The &quot;Stop&quot; button for example should have a very short dwell time to help stop the chair in an emergency. 
        ///The &quot;Start&quot; button should have a very long dwell time to prevent accidental activation..
        /// </summary>
        public static string SettingDescription_DwellTimes {
            get {
                return ResourceManager.GetString("SettingDescription_DwellTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to With this setting enabled, use the left &quot;ctrl&quot; key to toggle the mouse cursor visiblity..
        /// </summary>
        public static string SettingDescription_HideMouse {
            get {
                return ResourceManager.GetString("SettingDescription_HideMouse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The forward deflection when the backward button is presssed..
        /// </summary>
        public static string SettingDescription_ProfileSpeed_Backward {
            get {
                return ResourceManager.GetString("SettingDescription_ProfileSpeed_Backward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The forward deflection when the forward button is presssed..
        /// </summary>
        public static string SettingDescription_ProfileSpeed_Forward {
            get {
                return ResourceManager.GetString("SettingDescription_ProfileSpeed_Forward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the profile speed. This will be used to identify this speed to the user..
        /// </summary>
        public static string SettingDescription_ProfileSpeed_Name {
            get {
                return ResourceManager.GetString("SettingDescription_ProfileSpeed_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The X deflection when the right or left buttons are pressed..
        /// </summary>
        public static string SettingDescription_ProfileSpeed_X {
            get {
                return ResourceManager.GetString("SettingDescription_ProfileSpeed_X", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Appearance.
        /// </summary>
        public static string SettingGroupName_Appearance {
            get {
                return ResourceManager.GetString("SettingGroupName_Appearance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forward View Camera.
        /// </summary>
        public static string SettingGroupName_Camera {
            get {
                return ResourceManager.GetString("SettingGroupName_Camera", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Settings.
        /// </summary>
        public static string SettingGroupName_DeviceConnection {
            get {
                return ResourceManager.GetString("SettingGroupName_DeviceConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dwell Click Settings.
        /// </summary>
        public static string SettingGroupName_DwellClick {
            get {
                return ResourceManager.GetString("SettingGroupName_DwellClick", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dwell Times.
        /// </summary>
        public static string SettingGroupName_DwellTimes {
            get {
                return ResourceManager.GetString("SettingGroupName_DwellTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eyegaze System Interface.
        /// </summary>
        public static string SettingGroupName_EyegazeInterface {
            get {
                return ResourceManager.GetString("SettingGroupName_EyegazeInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language.
        /// </summary>
        public static string SettingGroupName_Language {
            get {
                return ResourceManager.GetString("SettingGroupName_Language", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profiles.
        /// </summary>
        public static string SettingGroupName_ProfileSelection {
            get {
                return ResourceManager.GetString("SettingGroupName_ProfileSelection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile Settings.
        /// </summary>
        public static string SettingGroupName_ProfileSettings {
            get {
                return ResourceManager.GetString("SettingGroupName_ProfileSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile Speed Settings.
        /// </summary>
        public static string SettingGroupName_ProfileSpeed_Settings {
            get {
                return ResourceManager.GetString("SettingGroupName_ProfileSpeed_Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatically Connect at Startup.
        /// </summary>
        public static string SettingName_AutoConnect {
            get {
                return ResourceManager.GetString("SettingName_AutoConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Camera Enabled.
        /// </summary>
        public static string SettingName_CameraEnabled {
            get {
                return ResourceManager.GetString("SettingName_CameraEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overlay Opacity:.
        /// </summary>
        public static string SettingName_CameraOverlayOpacity {
            get {
                return ResourceManager.GetString("SettingName_CameraOverlayOpacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabled.
        /// </summary>
        public static string SettingName_DwellClickEnabled {
            get {
                return ResourceManager.GetString("SettingName_DwellClickEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dwell Repeat Delay.
        /// </summary>
        public static string SettingName_DwellClickRepeatDelay {
            get {
                return ResourceManager.GetString("SettingName_DwellClickRepeatDelay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Direction Buttons.
        /// </summary>
        public static string SettingName_DwellClickTime_DirectionButtons {
            get {
                return ResourceManager.GetString("SettingName_DwellClickTime_DirectionButtons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Standard.
        /// </summary>
        public static string SettingName_DwellClickTime_Standard {
            get {
                return ResourceManager.GetString("SettingName_DwellClickTime_Standard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Button.
        /// </summary>
        public static string SettingName_DwellClickTime_StartButton {
            get {
                return ResourceManager.GetString("SettingName_DwellClickTime_StartButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop Button.
        /// </summary>
        public static string SettingName_DwellClickTime_StopButton {
            get {
                return ResourceManager.GetString("SettingName_DwellClickTime_StopButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dwell Timeout.
        /// </summary>
        public static string SettingName_DwellClickTimeout {
            get {
                return ResourceManager.GetString("SettingName_DwellClickTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eyegaze System.
        /// </summary>
        public static string SettingName_EyegazeInterface {
            get {
                return ResourceManager.GetString("SettingName_EyegazeInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hide Mouse Cursor.
        /// </summary>
        public static string SettingName_HideMouse {
            get {
                return ResourceManager.GetString("SettingName_HideMouse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string SettingName_ProfileName {
            get {
                return ResourceManager.GetString("SettingName_ProfileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backward.
        /// </summary>
        public static string SettingName_ProfileSpeed_Backward {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_Backward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forward.
        /// </summary>
        public static string SettingName_ProfileSpeed_Forward {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_Forward", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string SettingName_ProfileSpeed_Name {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Left/Right.
        /// </summary>
        public static string SettingName_ProfileSpeed_X {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_X", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Left/Right Diagonal.
        /// </summary>
        public static string SettingName_ProfileSpeed_XDiag {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_XDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backward Diagonal.
        /// </summary>
        public static string SettingName_ProfileSpeed_YBackwardDiag {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_YBackwardDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forward Diagonal.
        /// </summary>
        public static string SettingName_ProfileSpeed_YForwardDiag {
            get {
                return ResourceManager.GetString("SettingName_ProfileSpeed_YForwardDiag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Safety Bypass.
        /// </summary>
        public static string SettingName_SafetyBypass {
            get {
                return ResourceManager.GetString("SettingName_SafetyBypass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Colors.
        /// </summary>
        public static string SettingName_ThemeColors {
            get {
                return ResourceManager.GetString("SettingName_ThemeColors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Images.
        /// </summary>
        public static string SettingName_ThemeImages {
            get {
                return ResourceManager.GetString("SettingName_ThemeImages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Styles.
        /// </summary>
        public static string SettingName_ThemeStyles {
            get {
                return ResourceManager.GetString("SettingName_ThemeStyles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limits.
        /// </summary>
        public static string SettingsGroupName_DeviceLimits {
            get {
                return ResourceManager.GetString("SettingsGroupName_DeviceLimits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trim.
        /// </summary>
        public static string SettingsGroupName_Trim {
            get {
                return ResourceManager.GetString("SettingsGroupName_Trim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        public static string StatusView_Speed_None {
            get {
                return ResourceManager.GetString("StatusView_Speed_None", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Camera.
        /// </summary>
        public static string ViewName_CameraConfiguration {
            get {
                return ResourceManager.GetString("ViewName_CameraConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup.
        /// </summary>
        public static string ViewName_Configuration {
            get {
                return ResourceManager.GetString("ViewName_Configuration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hardware.
        /// </summary>
        public static string ViewName_DeviceConfig {
            get {
                return ResourceManager.GetString("ViewName_DeviceConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eyegaze.
        /// </summary>
        public static string ViewName_EyegazeConfig {
            get {
                return ResourceManager.GetString("ViewName_EyegazeConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        public static string ViewName_GeneralConfiguration {
            get {
                return ResourceManager.GetString("ViewName_GeneralConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actions.
        /// </summary>
        public static string ViewName_Macros {
            get {
                return ResourceManager.GetString("ViewName_Macros", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit Actions.
        /// </summary>
        public static string ViewName_MacrosSettings {
            get {
                return ResourceManager.GetString("ViewName_MacrosSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profiles.
        /// </summary>
        public static string ViewName_ProfileConfig {
            get {
                return ResourceManager.GetString("ViewName_ProfileConfig", resourceCulture);
            }
        }
    }
}
