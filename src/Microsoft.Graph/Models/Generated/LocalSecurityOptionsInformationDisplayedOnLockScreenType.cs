// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum LocalSecurityOptionsInformationDisplayedOnLockScreenType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocalSecurityOptionsInformationDisplayedOnLockScreenType
    {
    
        /// <summary>
        /// not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// administrators
        /// </summary>
        Administrators = 1,
	
        /// <summary>
        /// administrators And Power Users
        /// </summary>
        AdministratorsAndPowerUsers = 2,
	
        /// <summary>
        /// administrators And Interactive Users
        /// </summary>
        AdministratorsAndInteractiveUsers = 3,
	
    }
}
