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
    /// The interface IBookingPersonRequest.
    /// </summary>
    public partial interface IBookingPersonRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingPerson using PUT.
        /// </summary>
        /// <param name="bookingPersonToCreate">The BookingPerson to create.</param>
        /// <returns>The created BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> CreateAsync(BookingPerson bookingPersonToCreate);        /// <summary>
        /// Creates the specified BookingPerson using PUT.
        /// </summary>
        /// <param name="bookingPersonToCreate">The BookingPerson to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> CreateAsync(BookingPerson bookingPersonToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BookingPerson.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BookingPerson.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingPerson.
        /// </summary>
        /// <returns>The BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> GetAsync();

        /// <summary>
        /// Gets the specified BookingPerson.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingPerson using PATCH.
        /// </summary>
        /// <param name="bookingPersonToUpdate">The BookingPerson to update.</param>
        /// <returns>The updated BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> UpdateAsync(BookingPerson bookingPersonToUpdate);

        /// <summary>
        /// Updates the specified BookingPerson using PATCH.
        /// </summary>
        /// <param name="bookingPersonToUpdate">The BookingPerson to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated BookingPerson.</returns>
        System.Threading.Tasks.Task<BookingPerson> UpdateAsync(BookingPerson bookingPersonToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingPersonRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingPersonRequest Expand(Expression<Func<BookingPerson, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingPersonRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingPersonRequest Select(Expression<Func<BookingPerson, object>> selectExpression);

    }
}
