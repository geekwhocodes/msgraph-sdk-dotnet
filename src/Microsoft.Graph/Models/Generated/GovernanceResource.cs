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
    /// The type Governance Resource.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GovernanceResource : Entity
    {
    
        /// <summary>
        /// Gets or sets external id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets onboard date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onboardDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnboardDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parent", Required = Newtonsoft.Json.Required.Default)]
        public GovernanceResource Parent { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IGovernanceResourceRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IGovernanceResourceRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets role assignment requests.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignmentRequests", Required = Newtonsoft.Json.Required.Default)]
        public IGovernanceResourceRoleAssignmentRequestsCollectionPage RoleAssignmentRequests { get; set; }
    
        /// <summary>
        /// Gets or sets role settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleSettings", Required = Newtonsoft.Json.Required.Default)]
        public IGovernanceResourceRoleSettingsCollectionPage RoleSettings { get; set; }
    
    }
}

