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
    /// The interface IGovernanceRoleAssignmentRequestRequestBuilder.
    /// </summary>
    public partial interface IGovernanceRoleAssignmentRequestRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGovernanceRoleAssignmentRequestRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGovernanceRoleAssignmentRequestRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Resource.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        IGovernanceResourceRequestBuilder Resource { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinition.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleDefinitionRequestBuilder"/>.</returns>
        IGovernanceRoleDefinitionRequestBuilder RoleDefinition { get; }

        /// <summary>
        /// Gets the request builder for Subject.
        /// </summary>
        /// <returns>The <see cref="IGovernanceSubjectRequestBuilder"/>.</returns>
        IGovernanceSubjectRequestBuilder Subject { get; }
    
        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentRequestCancel.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestCancelRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentRequestCancelRequestBuilder Cancel();

        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentRequestUpdateRequest.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestUpdateRequestRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentRequestUpdateRequestRequestBuilder UpdateRequest(
            string decision = null,
            string assignmentState = null,
            GovernanceSchedule schedule = null,
            string reason = null);
    
    }
}
