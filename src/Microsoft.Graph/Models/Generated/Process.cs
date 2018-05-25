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
    /// The type Process.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Process
    {
    
        /// <summary>
        /// Gets or sets authenticodeHash256.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticodeHash256", Required = Newtonsoft.Json.Required.Default)]
        public string AuthenticodeHash256 { get; set; }
    
        /// <summary>
        /// Gets or sets commandLine.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "commandLine", Required = Newtonsoft.Json.Required.Default)]
        public string CommandLine { get; set; }
    
        /// <summary>
        /// Gets or sets createdDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets integrityLevel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "integrityLevel", Required = Newtonsoft.Json.Required.Default)]
        public ProcessIntegrityLevel? IntegrityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets isElevated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isElevated", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsElevated { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parentProcessCreatedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentProcessCreatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ParentProcessCreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets parentProcessId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentProcessId", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ParentProcessId { get; set; }
    
        /// <summary>
        /// Gets or sets parentProcessName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentProcessName", Required = Newtonsoft.Json.Required.Default)]
        public string ParentProcessName { get; set; }
    
        /// <summary>
        /// Gets or sets path.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "path", Required = Newtonsoft.Json.Required.Default)]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or sets processId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processId", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProcessId { get; set; }
    
        /// <summary>
        /// Gets or sets sha256.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sha256", Required = Newtonsoft.Json.Required.Default)]
        public string Sha256 { get; set; }
    
        /// <summary>
        /// Gets or sets accountName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountName", Required = Newtonsoft.Json.Required.Default)]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
