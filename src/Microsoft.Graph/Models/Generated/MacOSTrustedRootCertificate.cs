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
    /// The type Mac OSTrusted Root Certificate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSTrustedRootCertificate : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets trusted root certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustedRootCertificate", Required = Newtonsoft.Json.Required.Default)]
        public byte[] TrustedRootCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets cert file name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certFileName", Required = Newtonsoft.Json.Required.Default)]
        public string CertFileName { get; set; }
    
    }
}

