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
    /// The type AttributeMapping.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AttributeMapping
    {
    
        /// <summary>
        /// Gets or sets defaultValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultValue", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets exportMissingReferences.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exportMissingReferences", Required = Newtonsoft.Json.Required.Default)]
        public bool? ExportMissingReferences { get; set; }
    
        /// <summary>
        /// Gets or sets flowBehavior.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flowBehavior", Required = Newtonsoft.Json.Required.Default)]
        public AttributeFlowBehavior? FlowBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets flowType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flowType", Required = Newtonsoft.Json.Required.Default)]
        public AttributeFlowType? FlowType { get; set; }
    
        /// <summary>
        /// Gets or sets matchingPriority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "matchingPriority", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MatchingPriority { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Newtonsoft.Json.Required.Default)]
        public AttributeMappingSource Source { get; set; }
    
        /// <summary>
        /// Gets or sets targetAttributeName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetAttributeName", Required = Newtonsoft.Json.Required.Default)]
        public string TargetAttributeName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
