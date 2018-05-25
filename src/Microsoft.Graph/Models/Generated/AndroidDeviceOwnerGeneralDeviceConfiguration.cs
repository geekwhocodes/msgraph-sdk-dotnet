// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Device Owner General Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets accounts block modification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountsBlockModification", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountsBlockModification { get; set; }
    
        /// <summary>
        /// Gets or sets apps allow install from unknown sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsAllowInstallFromUnknownSources", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsAllowInstallFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets apps default permission policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsDefaultPermissionPolicy", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerDefaultAppPermissionPolicyType? AppsDefaultPermissionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets factory reset device administrator emails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryResetDeviceAdministratorEmails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> FactoryResetDeviceAdministratorEmails { get; set; }
    
        /// <summary>
        /// Gets or sets factory reset blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryResetBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FactoryResetBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk mode apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskModeApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> KioskModeApps { get; set; }
    
        /// <summary>
        /// Gets or sets microphone force mute.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microphoneForceMute", Required = Newtonsoft.Json.Required.Default)]
        public bool? MicrophoneForceMute { get; set; }
    
        /// <summary>
        /// Gets or sets network escape hatch allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkEscapeHatchAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? NetworkEscapeHatchAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets password block keyguard.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockKeyguard", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockKeyguard { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password count to block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordCountToBlock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordCountToBlock { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets safe boot blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "safeBootBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? SafeBootBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets security allow debugging features.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityAllowDebuggingFeatures", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityAllowDebuggingFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets status bar blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statusBarBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? StatusBarBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets stay on modes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stayOnModes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AndroidDeviceOwnerBatteryPluggedMode> StayOnModes { get; set; }
    
        /// <summary>
        /// Gets or sets users block add.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersBlockAdd", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsersBlockAdd { get; set; }
    
        /// <summary>
        /// Gets or sets users block remove.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersBlockRemove", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsersBlockRemove { get; set; }
    
        /// <summary>
        /// Gets or sets volume block adjustment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "volumeBlockAdjustment", Required = Newtonsoft.Json.Required.Default)]
        public bool? VolumeBlockAdjustment { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block edit configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockEditConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockEditConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block edit policy defined configurations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockEditPolicyDefinedConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockEditPolicyDefinedConfigurations { get; set; }
    
    }
}

