// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GovernanceRoleAssignmentRequestRequestBuilder.
    /// </summary>
    public partial class GovernanceRoleAssignmentRequestRequestBuilder : EntityRequestBuilder, IGovernanceRoleAssignmentRequestRequestBuilder
    {

        /// <summary>
        /// Constructs a new GovernanceRoleAssignmentRequestRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GovernanceRoleAssignmentRequestRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleAssignmentRequestRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IGovernanceRoleAssignmentRequestRequest Request(IEnumerable<Option> options)
        {
            return new GovernanceRoleAssignmentRequestRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Resource.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        public IGovernanceResourceRequestBuilder Resource
        {
            get
            {
                return new GovernanceResourceRequestBuilder(this.AppendSegmentToRequestUrl("resource"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RoleDefinition.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleDefinitionRequestBuilder"/>.</returns>
        public IGovernanceRoleDefinitionRequestBuilder RoleDefinition
        {
            get
            {
                return new GovernanceRoleDefinitionRequestBuilder(this.AppendSegmentToRequestUrl("roleDefinition"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Subject.
        /// </summary>
        /// <returns>The <see cref="IGovernanceSubjectRequestBuilder"/>.</returns>
        public IGovernanceSubjectRequestBuilder Subject
        {
            get
            {
                return new GovernanceSubjectRequestBuilder(this.AppendSegmentToRequestUrl("subject"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentRequestCancel.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestCancelRequestBuilder"/>.</returns>
        public IGovernanceRoleAssignmentRequestCancelRequestBuilder Cancel()
        {
            return new GovernanceRoleAssignmentRequestCancelRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cancel"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentRequestUpdateRequest.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestUpdateRequestRequestBuilder"/>.</returns>
        public IGovernanceRoleAssignmentRequestUpdateRequestRequestBuilder UpdateRequest(
            string decision = null,
            string assignmentState = null,
            GovernanceSchedule schedule = null,
            string reason = null)
        {
            return new GovernanceRoleAssignmentRequestUpdateRequestRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateRequest"),
                this.Client,
                decision,
                assignmentState,
                schedule,
                reason);
        }
    
    }
}
