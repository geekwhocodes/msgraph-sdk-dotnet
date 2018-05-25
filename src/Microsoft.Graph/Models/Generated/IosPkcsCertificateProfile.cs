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
    /// The type Ios Pkcs Certificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosPkcsCertificateProfile : IosCertificateProfileBase
    {
    
        /// <summary>
        /// Gets or sets certification authority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationAuthority", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationAuthorityName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationAuthorityName { get; set; }
    
        /// <summary>
        /// Gets or sets certificate template name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificateTemplateName", Required = Newtonsoft.Json.Required.Default)]
        public string CertificateTemplateName { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subjectAlternativeNameFormatString", Required = Newtonsoft.Json.Required.Default)]
        public string SubjectAlternativeNameFormatString { get; set; }
    
    }
}

