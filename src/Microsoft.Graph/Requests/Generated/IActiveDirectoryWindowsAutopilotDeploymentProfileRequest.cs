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
    /// The interface IActiveDirectoryWindowsAutopilotDeploymentProfileRequest.
    /// </summary>
    public partial interface IActiveDirectoryWindowsAutopilotDeploymentProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PUT.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <returns>The created ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> CreateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate);        /// <summary>
        /// Creates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PUT.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToCreate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> CreateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <returns>The ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> GetAsync();

        /// <summary>
        /// Gets the specified ActiveDirectoryWindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <returns>The updated ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> UpdateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate);

        /// <summary>
        /// Updates the specified ActiveDirectoryWindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="activeDirectoryWindowsAutopilotDeploymentProfileToUpdate">The ActiveDirectoryWindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ActiveDirectoryWindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<ActiveDirectoryWindowsAutopilotDeploymentProfile> UpdateAsync(ActiveDirectoryWindowsAutopilotDeploymentProfile activeDirectoryWindowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Expand(Expression<Func<ActiveDirectoryWindowsAutopilotDeploymentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IActiveDirectoryWindowsAutopilotDeploymentProfileRequest Select(Expression<Func<ActiveDirectoryWindowsAutopilotDeploymentProfile, object>> selectExpression);

    }
}
