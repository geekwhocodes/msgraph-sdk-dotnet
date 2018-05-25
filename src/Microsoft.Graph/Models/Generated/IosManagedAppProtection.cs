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
    /// The type Ios Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosManagedAppProtection : TargetedManagedAppProtection
    {
    
        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDataEncryptionType", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "faceIdBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets exempted app protocols.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptedAppProtocols", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ExemptedAppProtocols { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe sdk version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets allowed ios device models.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedIosDeviceModels", Required = Newtonsoft.Json.Required.Default)]
        public string AllowedIosDeviceModels { get; set; }
    
        /// <summary>
        /// Gets or sets app action if ios device model not allowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfIosDeviceModelNotAllowed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apps", Required = Newtonsoft.Json.Required.Default)]
        public IIosManagedAppProtectionAppsCollectionPage Apps { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

