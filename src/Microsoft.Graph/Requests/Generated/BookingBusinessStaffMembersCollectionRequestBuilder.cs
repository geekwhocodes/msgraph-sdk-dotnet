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
    /// The type BookingBusinessStaffMembersCollectionRequestBuilder.
    /// </summary>
    public partial class BookingBusinessStaffMembersCollectionRequestBuilder : BaseRequestBuilder, IBookingBusinessStaffMembersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new BookingBusinessStaffMembersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BookingBusinessStaffMembersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IBookingBusinessStaffMembersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IBookingBusinessStaffMembersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new BookingBusinessStaffMembersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBookingStaffMemberRequestBuilder"/> for the specified BookingBusinessBookingStaffMember.
        /// </summary>
        /// <param name="id">The ID for the BookingBusinessBookingStaffMember.</param>
        /// <returns>The <see cref="IBookingStaffMemberRequestBuilder"/>.</returns>
        public IBookingStaffMemberRequestBuilder this[string id]
        {
            get
            {
                return new BookingStaffMemberRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
