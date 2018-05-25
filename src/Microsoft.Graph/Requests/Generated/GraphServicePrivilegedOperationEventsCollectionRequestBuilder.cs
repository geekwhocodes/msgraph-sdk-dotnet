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
    /// The type GraphServicePrivilegedOperationEventsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServicePrivilegedOperationEventsCollectionRequestBuilder : BaseRequestBuilder, IGraphServicePrivilegedOperationEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServicePrivilegedOperationEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServicePrivilegedOperationEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServicePrivilegedOperationEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServicePrivilegedOperationEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServicePrivilegedOperationEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrivilegedOperationEventRequestBuilder"/> for the specified GraphServicePrivilegedOperationEvent.
        /// </summary>
        /// <param name="id">The ID for the GraphServicePrivilegedOperationEvent.</param>
        /// <returns>The <see cref="IPrivilegedOperationEventRequestBuilder"/>.</returns>
        public IPrivilegedOperationEventRequestBuilder this[string id]
        {
            get
            {
                return new PrivilegedOperationEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
