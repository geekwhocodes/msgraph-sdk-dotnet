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
    /// The interface IManagedIOSStoreAppRequest.
    /// </summary>
    public partial interface IManagedIOSStoreAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedIOSStoreApp using PUT.
        /// </summary>
        /// <param name="managedIOSStoreAppToCreate">The ManagedIOSStoreApp to create.</param>
        /// <returns>The created ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> CreateAsync(ManagedIOSStoreApp managedIOSStoreAppToCreate);        /// <summary>
        /// Creates the specified ManagedIOSStoreApp using PUT.
        /// </summary>
        /// <param name="managedIOSStoreAppToCreate">The ManagedIOSStoreApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> CreateAsync(ManagedIOSStoreApp managedIOSStoreAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedIOSStoreApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedIOSStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedIOSStoreApp.
        /// </summary>
        /// <returns>The ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> GetAsync();

        /// <summary>
        /// Gets the specified ManagedIOSStoreApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PATCH.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp to update.</param>
        /// <returns>The updated ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> UpdateAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate);

        /// <summary>
        /// Updates the specified ManagedIOSStoreApp using PATCH.
        /// </summary>
        /// <param name="managedIOSStoreAppToUpdate">The ManagedIOSStoreApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedIOSStoreApp.</returns>
        System.Threading.Tasks.Task<ManagedIOSStoreApp> UpdateAsync(ManagedIOSStoreApp managedIOSStoreAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Expand(Expression<Func<ManagedIOSStoreApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedIOSStoreAppRequest Select(Expression<Func<ManagedIOSStoreApp, object>> selectExpression);

    }
}
