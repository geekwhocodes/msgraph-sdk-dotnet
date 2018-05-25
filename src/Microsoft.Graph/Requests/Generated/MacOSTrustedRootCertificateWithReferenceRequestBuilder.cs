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
    /// The type MacOSTrustedRootCertificateWithReferenceRequestBuilder.
    /// </summary>
    public partial class MacOSTrustedRootCertificateWithReferenceRequestBuilder : BaseRequestBuilder, IMacOSTrustedRootCertificateWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new MacOSTrustedRootCertificateWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MacOSTrustedRootCertificateWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMacOSTrustedRootCertificateWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMacOSTrustedRootCertificateWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new MacOSTrustedRootCertificateWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the macOSTrustedRootCertificate.
        /// </summary>
        /// <returns>The <see cref="IMacOSTrustedRootCertificateReferenceRequestBuilder"/>.</returns>
        public IMacOSTrustedRootCertificateReferenceRequestBuilder Reference
        {
            get
            {
                return new MacOSTrustedRootCertificateReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
