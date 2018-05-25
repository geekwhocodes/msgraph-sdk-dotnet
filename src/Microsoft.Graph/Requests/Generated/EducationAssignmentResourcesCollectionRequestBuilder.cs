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
    /// The type EducationAssignmentResourcesCollectionRequestBuilder.
    /// </summary>
    public partial class EducationAssignmentResourcesCollectionRequestBuilder : BaseRequestBuilder, IEducationAssignmentResourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EducationAssignmentResourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationAssignmentResourcesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationAssignmentResourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationAssignmentResourcesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EducationAssignmentResourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationAssignmentResourceRequestBuilder"/> for the specified EducationAssignmentEducationAssignmentResource.
        /// </summary>
        /// <param name="id">The ID for the EducationAssignmentEducationAssignmentResource.</param>
        /// <returns>The <see cref="IEducationAssignmentResourceRequestBuilder"/>.</returns>
        public IEducationAssignmentResourceRequestBuilder this[string id]
        {
            get
            {
                return new EducationAssignmentResourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
