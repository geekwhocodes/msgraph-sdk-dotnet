// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceProtectionOverview.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceProtectionOverview
    {
    
        /// <summary>
        /// Gets or sets totalReportedDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalReportedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalReportedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets inactiveThreatAgentDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inactiveThreatAgentDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InactiveThreatAgentDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknownStateThreatAgentDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownStateThreatAgentDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownStateThreatAgentDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pendingSignatureUpdateDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingSignatureUpdateDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingSignatureUpdateDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets cleanDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cleanDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CleanDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pendingFullScanDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingFullScanDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingFullScanDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pendingRestartDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingRestartDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingRestartDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pendingManualStepsDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingManualStepsDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingManualStepsDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pendingOfflineScanDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingOfflineScanDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingOfflineScanDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets criticalFailuresDeviceCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criticalFailuresDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CriticalFailuresDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
