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
    /// The type ListItemActivitiesCollectionRequestBuilder.
    /// </summary>
    public partial class ListItemActivitiesCollectionRequestBuilder : BaseRequestBuilder, IListItemActivitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ListItemActivitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ListItemActivitiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IListItemActivitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IListItemActivitiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ListItemActivitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IItemActivityRequestBuilder"/> for the specified ListItemItemActivity.
        /// </summary>
        /// <param name="id">The ID for the ListItemItemActivity.</param>
        /// <returns>The <see cref="IItemActivityRequestBuilder"/>.</returns>
        public IItemActivityRequestBuilder this[string id]
        {
            get
            {
                return new ItemActivityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
