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
    /// The type GraphServiceDataSharingConsentsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDataSharingConsentsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDataSharingConsentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDataSharingConsentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDataSharingConsentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDataSharingConsentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDataSharingConsentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDataSharingConsentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDataSharingConsentRequestBuilder"/> for the specified GraphServiceDataSharingConsent.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDataSharingConsent.</param>
        /// <returns>The <see cref="IDataSharingConsentRequestBuilder"/>.</returns>
        public IDataSharingConsentRequestBuilder this[string id]
        {
            get
            {
                return new DataSharingConsentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
