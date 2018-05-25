// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial class GovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder : BaseRequestBuilder, IGovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GovernanceScenarioRoleAssignmentRequestsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGovernanceScenarioRoleAssignmentRequestsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGovernanceScenarioRoleAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GovernanceScenarioRoleAssignmentRequestsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGovernanceRoleAssignmentRequestRequestBuilder"/> for the specified GovernanceScenarioGovernanceRoleAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the GovernanceScenarioGovernanceRoleAssignmentRequest.</param>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestRequestBuilder"/>.</returns>
        public IGovernanceRoleAssignmentRequestRequestBuilder this[string id]
        {
            get
            {
                return new GovernanceRoleAssignmentRequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
