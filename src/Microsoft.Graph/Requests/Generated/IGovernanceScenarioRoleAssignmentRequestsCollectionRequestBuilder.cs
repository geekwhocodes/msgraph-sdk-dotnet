// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGovernanceScenarioRoleAssignmentRequestsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGovernanceScenarioRoleAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGovernanceRoleAssignmentRequestRequestBuilder"/> for the specified GovernanceRoleAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the GovernanceRoleAssignmentRequest.</param>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestRequestBuilder"/>.</returns>
        IGovernanceRoleAssignmentRequestRequestBuilder this[string id] { get; }

        
    }
}
