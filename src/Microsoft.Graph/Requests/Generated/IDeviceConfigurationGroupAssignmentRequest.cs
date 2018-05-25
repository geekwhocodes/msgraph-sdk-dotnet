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
    /// The interface IDeviceConfigurationGroupAssignmentRequest.
    /// </summary>
    public partial interface IDeviceConfigurationGroupAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationGroupAssignment using PUT.
        /// </summary>
        /// <param name="deviceConfigurationGroupAssignmentToCreate">The DeviceConfigurationGroupAssignment to create.</param>
        /// <returns>The created DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> CreateAsync(DeviceConfigurationGroupAssignment deviceConfigurationGroupAssignmentToCreate);        /// <summary>
        /// Creates the specified DeviceConfigurationGroupAssignment using PUT.
        /// </summary>
        /// <param name="deviceConfigurationGroupAssignmentToCreate">The DeviceConfigurationGroupAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> CreateAsync(DeviceConfigurationGroupAssignment deviceConfigurationGroupAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceConfigurationGroupAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceConfigurationGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationGroupAssignment.
        /// </summary>
        /// <returns>The DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationGroupAssignment using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationGroupAssignmentToUpdate">The DeviceConfigurationGroupAssignment to update.</param>
        /// <returns>The updated DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> UpdateAsync(DeviceConfigurationGroupAssignment deviceConfigurationGroupAssignmentToUpdate);

        /// <summary>
        /// Updates the specified DeviceConfigurationGroupAssignment using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationGroupAssignmentToUpdate">The DeviceConfigurationGroupAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceConfigurationGroupAssignment.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationGroupAssignment> UpdateAsync(DeviceConfigurationGroupAssignment deviceConfigurationGroupAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationGroupAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationGroupAssignmentRequest Expand(Expression<Func<DeviceConfigurationGroupAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationGroupAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationGroupAssignmentRequest Select(Expression<Func<DeviceConfigurationGroupAssignment, object>> selectExpression);

    }
}
