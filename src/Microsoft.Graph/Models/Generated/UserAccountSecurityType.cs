// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum UserAccountSecurityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum UserAccountSecurityType
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = -1,
	
        /// <summary>
        /// standard
        /// </summary>
        Standard = 0,
	
        /// <summary>
        /// power
        /// </summary>
        Power = 1,
	
        /// <summary>
        /// administrator
        /// </summary>
        Administrator = 2,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
