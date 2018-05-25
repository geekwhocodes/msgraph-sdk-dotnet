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
    /// The type Windows Assigned Access Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsAssignedAccessProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets profile name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileName", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets show task bar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showTaskBar", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowTaskBar { get; set; }
    
        /// <summary>
        /// Gets or sets app user model ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appUserModelIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AppUserModelIds { get; set; }
    
        /// <summary>
        /// Gets or sets desktop app paths.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "desktopAppPaths", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DesktopAppPaths { get; set; }
    
        /// <summary>
        /// Gets or sets user accounts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAccounts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UserAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets start menu layout xml.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startMenuLayoutXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] StartMenuLayoutXml { get; set; }
    
    }
}

