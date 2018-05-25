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
    /// The type Skype For Business Organizer Activity Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SkypeForBusinessOrganizerActivityCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets im.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "im", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Im { get; set; }
    
        /// <summary>
        /// Gets or sets audio video.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioVideo", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AudioVideo { get; set; }
    
        /// <summary>
        /// Gets or sets app sharing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appSharing", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AppSharing { get; set; }
    
        /// <summary>
        /// Gets or sets web.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "web", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Web { get; set; }
    
        /// <summary>
        /// Gets or sets dial in out3rd party.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dialInOut3rdParty", Required = Newtonsoft.Json.Required.Default)]
        public Int64? DialInOut3rdParty { get; set; }
    
        /// <summary>
        /// Gets or sets dial in out microsoft.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dialInOutMicrosoft", Required = Newtonsoft.Json.Required.Default)]
        public Int64? DialInOutMicrosoft { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}

