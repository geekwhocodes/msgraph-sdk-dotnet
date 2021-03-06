// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsStartMenuAppListVisibilityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum WindowsStartMenuAppListVisibilityType
    {
    
        /// <summary>
        /// user Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// collapse
        /// </summary>
        Collapse = 1,
	
        /// <summary>
        /// remove
        /// </summary>
        Remove = 2,
	
        /// <summary>
        /// disable Settings App
        /// </summary>
        DisableSettingsApp = 4,
	
    }
}
