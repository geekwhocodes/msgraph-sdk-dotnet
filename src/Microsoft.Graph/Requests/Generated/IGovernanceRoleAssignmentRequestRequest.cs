// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGovernanceRoleAssignmentRequestRequest.
    /// </summary>
    public partial interface IGovernanceRoleAssignmentRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernanceRoleAssignmentRequestObject using PUT.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToCreate">The GovernanceRoleAssignmentRequestObject to create.</param>
        /// <returns>The created GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> CreateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToCreate);        /// <summary>
        /// Creates the specified GovernanceRoleAssignmentRequestObject using PUT.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToCreate">The GovernanceRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> CreateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignmentRequestObject.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernanceRoleAssignmentRequestObject.
        /// </summary>
        /// <returns>The GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified GovernanceRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernanceRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToUpdate">The GovernanceRoleAssignmentRequestObject to update.</param>
        /// <returns>The updated GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> UpdateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToUpdate);

        /// <summary>
        /// Updates the specified GovernanceRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentRequestObjectToUpdate">The GovernanceRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GovernanceRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignmentRequestObject> UpdateAsync(GovernanceRoleAssignmentRequestObject governanceRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequestRequest Expand(Expression<Func<GovernanceRoleAssignmentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequestRequest Select(Expression<Func<GovernanceRoleAssignmentRequestObject, object>> selectExpression);

    }
}
