// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWindowsAutopilotDeploymentProfileRequestBuilder.
    /// </summary>
    public partial interface IWindowsAutopilotDeploymentProfileRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWindowsAutopilotDeploymentProfileRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWindowsAutopilotDeploymentProfileRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AssignedDevices.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignedDevicesCollectionRequestBuilder"/>.</returns>
        IWindowsAutopilotDeploymentProfileAssignedDevicesCollectionRequestBuilder AssignedDevices { get; }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder"/>.</returns>
        IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder Assignments { get; }
    
        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeploymentProfileAssign.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignRequestBuilder"/>.</returns>
        IWindowsAutopilotDeploymentProfileAssignRequestBuilder Assign(
            IEnumerable<string> deviceIds = null);
    
    }
}
