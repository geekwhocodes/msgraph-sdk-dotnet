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
    /// The type Privileged Role Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrivilegedRoleAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets role id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleId", Required = Newtonsoft.Json.Required.Default)]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets is elevated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isElevated", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsElevated { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets result message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resultMessage", Required = Newtonsoft.Json.Required.Default)]
        public string ResultMessage { get; set; }
    
        /// <summary>
        /// Gets or sets role info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleInfo", Required = Newtonsoft.Json.Required.Default)]
        public PrivilegedRole RoleInfo { get; set; }
    
    }
}

