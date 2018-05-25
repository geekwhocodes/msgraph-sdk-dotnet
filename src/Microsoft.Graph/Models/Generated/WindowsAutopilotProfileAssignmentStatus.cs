// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsAutopilotProfileAssignmentStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsAutopilotProfileAssignmentStatus
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// assigned In Sync
        /// </summary>
        AssignedInSync = 1,
	
        /// <summary>
        /// assigned Out Of Sync
        /// </summary>
        AssignedOutOfSync = 2,
	
        /// <summary>
        /// assigned Unkown Sync State
        /// </summary>
        AssignedUnkownSyncState = 3,
	
        /// <summary>
        /// not Assigned
        /// </summary>
        NotAssigned = 4,
	
        /// <summary>
        /// pending
        /// </summary>
        Pending = 5,
	
        /// <summary>
        /// failed
        /// </summary>
        Failed = 6,
	
    }
}
