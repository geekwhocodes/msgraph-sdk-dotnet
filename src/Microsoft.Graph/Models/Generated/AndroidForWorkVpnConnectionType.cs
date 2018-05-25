// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AndroidForWorkVpnConnectionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidForWorkVpnConnectionType
    {
    
        /// <summary>
        /// cisco Any Connect
        /// </summary>
        CiscoAnyConnect = 0,
	
        /// <summary>
        /// pulse Secure
        /// </summary>
        PulseSecure = 1,
	
        /// <summary>
        /// f5Edge Client
        /// </summary>
        F5EdgeClient = 2,
	
        /// <summary>
        /// dell Sonic Wall Mobile Connect
        /// </summary>
        DellSonicWallMobileConnect = 3,
	
        /// <summary>
        /// check Point Capsule Vpn
        /// </summary>
        CheckPointCapsuleVpn = 4,
	
        /// <summary>
        /// citrix
        /// </summary>
        Citrix = 5,
	
        /// <summary>
        /// palo Alto Global Protect
        /// </summary>
        PaloAltoGlobalProtect = 6,
	
    }
}
