// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type OAuth2PermissionGrantWithReferenceRequestBuilder.
    /// </summary>
    public partial class OAuth2PermissionGrantWithReferenceRequestBuilder : BaseRequestBuilder, IOAuth2PermissionGrantWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new OAuth2PermissionGrantWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OAuth2PermissionGrantWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOAuth2PermissionGrantWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOAuth2PermissionGrantWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new OAuth2PermissionGrantWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the oAuth2PermissionGrant.
        /// </summary>
        /// <returns>The <see cref="IOAuth2PermissionGrantReferenceRequestBuilder"/>.</returns>
        public IOAuth2PermissionGrantReferenceRequestBuilder Reference
        {
            get
            {
                return new OAuth2PermissionGrantReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
