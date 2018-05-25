// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionResponse.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ReportRootGetOffice365GroupsActivityStorageCollectionResponse.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class ReportRootGetOffice365GroupsActivityStorageCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IReportRootGetOffice365GroupsActivityStorageCollectionPage"/> value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName ="value", Required = Required.Default)]
        public IReportRootGetOffice365GroupsActivityStorageCollectionPage Value { get; set; }
        
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
