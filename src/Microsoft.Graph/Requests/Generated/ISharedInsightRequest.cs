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
    /// The interface ISharedInsightRequest.
    /// </summary>
    public partial interface ISharedInsightRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedInsight using PUT.
        /// </summary>
        /// <param name="sharedInsightToCreate">The SharedInsight to create.</param>
        /// <returns>The created SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> CreateAsync(SharedInsight sharedInsightToCreate);        /// <summary>
        /// Creates the specified SharedInsight using PUT.
        /// </summary>
        /// <param name="sharedInsightToCreate">The SharedInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> CreateAsync(SharedInsight sharedInsightToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharedInsight.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharedInsight.
        /// </summary>
        /// <returns>The SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> GetAsync();

        /// <summary>
        /// Gets the specified SharedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharedInsight using PATCH.
        /// </summary>
        /// <param name="sharedInsightToUpdate">The SharedInsight to update.</param>
        /// <returns>The updated SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> UpdateAsync(SharedInsight sharedInsightToUpdate);

        /// <summary>
        /// Updates the specified SharedInsight using PATCH.
        /// </summary>
        /// <param name="sharedInsightToUpdate">The SharedInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> UpdateAsync(SharedInsight sharedInsightToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Expand(Expression<Func<SharedInsight, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Select(Expression<Func<SharedInsight, object>> selectExpression);

    }
}
