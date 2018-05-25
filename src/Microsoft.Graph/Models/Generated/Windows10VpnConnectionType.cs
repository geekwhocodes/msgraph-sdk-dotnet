// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum Windows10VpnConnectionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum Windows10VpnConnectionType
    {
    
        /// <summary>
        /// pulse Secure
        /// </summary>
        PulseSecure = 0,
	
        /// <summary>
        /// f5Edge Client
        /// </summary>
        F5EdgeClient = 1,
	
        /// <summary>
        /// dell Sonic Wall Mobile Connect
        /// </summary>
        DellSonicWallMobileConnect = 2,
	
        /// <summary>
        /// check Point Capsule Vpn
        /// </summary>
        CheckPointCapsuleVpn = 3,
	
        /// <summary>
        /// automatic
        /// </summary>
        Automatic = 4,
	
        /// <summary>
        /// ik Ev2
        /// </summary>
        IkEv2 = 5,
	
        /// <summary>
        /// l2tp
        /// </summary>
        L2tp = 6,
	
        /// <summary>
        /// pptp
        /// </summary>
        Pptp = 7,
	
        /// <summary>
        /// citrix
        /// </summary>
        Citrix = 8,
	
    }
}
