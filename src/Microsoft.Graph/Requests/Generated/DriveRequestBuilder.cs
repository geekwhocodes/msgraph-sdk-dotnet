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
    /// The type DriveRequestBuilder.
    /// </summary>
    public partial class DriveRequestBuilder : BaseItemRequestBuilder, IDriveRequestBuilder
    {

        /// <summary>
        /// Constructs a new DriveRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DriveRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDriveRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDriveRequest Request(IEnumerable<Option> options)
        {
            return new DriveRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IDriveActivitiesCollectionRequestBuilder"/>.</returns>
        public IDriveActivitiesCollectionRequestBuilder Activities
        {
            get
            {
                return new DriveActivitiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("activities"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Items.
        /// </summary>
        /// <returns>The <see cref="IDriveItemsCollectionRequestBuilder"/>.</returns>
        public IDriveItemsCollectionRequestBuilder Items
        {
            get
            {
                return new DriveItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("items"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for List.
        /// </summary>
        /// <returns>The <see cref="IListRequestBuilder"/>.</returns>
        public IListRequestBuilder List
        {
            get
            {
                return new ListRequestBuilder(this.AppendSegmentToRequestUrl("list"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Root.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        public IDriveItemRequestBuilder Root
        {
            get
            {
                return new DriveItemRequestBuilder(this.AppendSegmentToRequestUrl("root"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Special.
        /// </summary>
        /// <returns>The <see cref="IDriveSpecialCollectionRequestBuilder"/>.</returns>
        public IDriveSpecialCollectionRequestBuilder Special
        {
            get
            {
                return new DriveSpecialCollectionRequestBuilder(this.AppendSegmentToRequestUrl("special"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DriveRecent.
        /// </summary>
        /// <returns>The <see cref="IDriveRecentRequestBuilder"/>.</returns>
        public IDriveRecentRequestBuilder Recent()
        {
            return new DriveRecentRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.recent"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DriveSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveSearchRequestBuilder"/>.</returns>
        public IDriveSearchRequestBuilder Search(
            string q = null)
        {
            return new DriveSearchRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.search"),
                this.Client,
                q);
        }

        /// <summary>
        /// Gets the request builder for DriveSharedWithMe.
        /// </summary>
        /// <returns>The <see cref="IDriveSharedWithMeRequestBuilder"/>.</returns>
        public IDriveSharedWithMeRequestBuilder SharedWithMe()
        {
            return new DriveSharedWithMeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sharedWithMe"),
                this.Client);
        }
    
    }
}
