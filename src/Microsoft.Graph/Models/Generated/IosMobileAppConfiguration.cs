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
    /// The type Ios Mobile App Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosMobileAppConfiguration : ManagedDeviceMobileAppConfiguration
    {
    
        /// <summary>
        /// Gets or sets setting xml.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingXml", Required = Newtonsoft.Json.Required.Default)]
        public string SettingXml { get; set; }
    
        /// <summary>
        /// Gets or sets encoded setting xml.
        /// mdm app configuration Base64 binary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encodedSettingXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] EncodedSettingXml { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// app configuration setting items.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppConfigurationSettingItem> Settings { get; set; }
    
    }
}

