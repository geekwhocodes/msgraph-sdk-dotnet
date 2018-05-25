// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum KeySize.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum KeySize
    {
    
        /// <summary>
        /// size1024
        /// </summary>
        Size1024 = 0,
	
        /// <summary>
        /// size2048
        /// </summary>
        Size2048 = 1,
	
    }
}
