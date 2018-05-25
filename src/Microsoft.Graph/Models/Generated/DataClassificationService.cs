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
    /// The type Data Classification Service.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DataClassificationService : Entity
    {
    
        /// <summary>
        /// Gets or sets sensitive types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sensitiveTypes", Required = Newtonsoft.Json.Required.Default)]
        public IDataClassificationServiceSensitiveTypesCollectionPage SensitiveTypes { get; set; }
    
        /// <summary>
        /// Gets or sets jobs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobs", Required = Newtonsoft.Json.Required.Default)]
        public IDataClassificationServiceJobsCollectionPage Jobs { get; set; }
    
        /// <summary>
        /// Gets or sets classify text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classifyText", Required = Newtonsoft.Json.Required.Default)]
        public IDataClassificationServiceClassifyTextCollectionPage ClassifyText { get; set; }
    
        /// <summary>
        /// Gets or sets classify file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classifyFile", Required = Newtonsoft.Json.Required.Default)]
        public IDataClassificationServiceClassifyFileCollectionPage ClassifyFile { get; set; }
    
    }
}

