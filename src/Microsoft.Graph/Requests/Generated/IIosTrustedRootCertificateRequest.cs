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
    /// The interface IIosTrustedRootCertificateRequest.
    /// </summary>
    public partial interface IIosTrustedRootCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosTrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToCreate">The IosTrustedRootCertificate to create.</param>
        /// <returns>The created IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> CreateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToCreate);        /// <summary>
        /// Creates the specified IosTrustedRootCertificate using PUT.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToCreate">The IosTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> CreateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosTrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosTrustedRootCertificate.
        /// </summary>
        /// <returns>The IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified IosTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate to update.</param>
        /// <returns>The updated IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> UpdateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate);

        /// <summary>
        /// Updates the specified IosTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="iosTrustedRootCertificateToUpdate">The IosTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<IosTrustedRootCertificate> UpdateAsync(IosTrustedRootCertificate iosTrustedRootCertificateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Expand(Expression<Func<IosTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosTrustedRootCertificateRequest Select(Expression<Func<IosTrustedRootCertificate, object>> selectExpression);

    }
}
