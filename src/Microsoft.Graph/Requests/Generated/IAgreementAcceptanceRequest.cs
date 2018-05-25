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
    /// The interface IAgreementAcceptanceRequest.
    /// </summary>
    public partial interface IAgreementAcceptanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AgreementAcceptance using PUT.
        /// </summary>
        /// <param name="agreementAcceptanceToCreate">The AgreementAcceptance to create.</param>
        /// <returns>The created AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> CreateAsync(AgreementAcceptance agreementAcceptanceToCreate);        /// <summary>
        /// Creates the specified AgreementAcceptance using PUT.
        /// </summary>
        /// <param name="agreementAcceptanceToCreate">The AgreementAcceptance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> CreateAsync(AgreementAcceptance agreementAcceptanceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AgreementAcceptance.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AgreementAcceptance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AgreementAcceptance.
        /// </summary>
        /// <returns>The AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> GetAsync();

        /// <summary>
        /// Gets the specified AgreementAcceptance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AgreementAcceptance using PATCH.
        /// </summary>
        /// <param name="agreementAcceptanceToUpdate">The AgreementAcceptance to update.</param>
        /// <returns>The updated AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> UpdateAsync(AgreementAcceptance agreementAcceptanceToUpdate);

        /// <summary>
        /// Updates the specified AgreementAcceptance using PATCH.
        /// </summary>
        /// <param name="agreementAcceptanceToUpdate">The AgreementAcceptance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AgreementAcceptance.</returns>
        System.Threading.Tasks.Task<AgreementAcceptance> UpdateAsync(AgreementAcceptance agreementAcceptanceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementAcceptanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementAcceptanceRequest Expand(Expression<Func<AgreementAcceptance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementAcceptanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAgreementAcceptanceRequest Select(Expression<Func<AgreementAcceptance, object>> selectExpression);

    }
}
