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
    /// The type GraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceSuspiciousIpRiskEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceSuspiciousIpRiskEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceSuspiciousIpRiskEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceSuspiciousIpRiskEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISuspiciousIpRiskEventRequestBuilder"/> for the specified GraphServiceSuspiciousIpRiskEvent.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceSuspiciousIpRiskEvent.</param>
        /// <returns>The <see cref="ISuspiciousIpRiskEventRequestBuilder"/>.</returns>
        public ISuspiciousIpRiskEventRequestBuilder this[string id]
        {
            get
            {
                return new SuspiciousIpRiskEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
