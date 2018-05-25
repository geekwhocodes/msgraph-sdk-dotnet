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
    /// The type Apple Device Features Configuration Base.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppleDeviceFeaturesConfigurationBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AppleDeviceFeaturesConfigurationBase constructor
		///</summary>
        protected internal AppleDeviceFeaturesConfigurationBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets air print destinations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "airPrintDestinations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AirPrintDestination> AirPrintDestinations { get; set; }
    
    }
}

