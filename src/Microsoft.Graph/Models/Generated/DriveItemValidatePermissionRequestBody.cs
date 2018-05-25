// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DriveItemValidatePermissionRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItemValidatePermissionRequestBody
    {
    
        /// <summary>
        /// Gets or sets ChallengeToken.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "challengeToken", Required = Newtonsoft.Json.Required.Default)]
        public string ChallengeToken { get; set; }
    
        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "password", Required = Newtonsoft.Json.Required.Default)]
        public string Password { get; set; }
    
    }
}
