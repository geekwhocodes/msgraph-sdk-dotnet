// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AndroidWorkProfileTrustedRootCertificateReferenceRequestBuilder.
    /// </summary>
    public partial class AndroidWorkProfileTrustedRootCertificateReferenceRequestBuilder : BaseRequestBuilder, IAndroidWorkProfileTrustedRootCertificateReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new AndroidWorkProfileTrustedRootCertificateReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidWorkProfileTrustedRootCertificateReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAndroidWorkProfileTrustedRootCertificateReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAndroidWorkProfileTrustedRootCertificateReferenceRequest Request(IEnumerable<Option> options)
        {
            return new AndroidWorkProfileTrustedRootCertificateReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
