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
    /// The type VppTokenRevokeLicensesActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class VppTokenRevokeLicensesActionResult : VppTokenActionResult
    {
    
        /// <summary>
        /// Gets or sets totalLicensesCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicensesCount { get; set; }
    
        /// <summary>
        /// Gets or sets failedLicensesCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedLicensesCount { get; set; }
    
        /// <summary>
        /// Gets or sets actionFailureReason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionFailureReason", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenActionFailureReason? ActionFailureReason { get; set; }
    
    }
}
