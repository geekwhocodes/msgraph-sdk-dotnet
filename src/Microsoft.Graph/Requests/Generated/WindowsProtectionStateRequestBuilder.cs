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
    /// The type WindowsProtectionStateRequestBuilder.
    /// </summary>
    public partial class WindowsProtectionStateRequestBuilder : EntityRequestBuilder, IWindowsProtectionStateRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsProtectionStateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsProtectionStateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsProtectionStateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsProtectionStateRequest Request(IEnumerable<Option> options)
        {
            return new WindowsProtectionStateRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DetectedMalwareState.
        /// </summary>
        /// <returns>The <see cref="IWindowsProtectionStateDetectedMalwareStateCollectionRequestBuilder"/>.</returns>
        public IWindowsProtectionStateDetectedMalwareStateCollectionRequestBuilder DetectedMalwareState
        {
            get
            {
                return new WindowsProtectionStateDetectedMalwareStateCollectionRequestBuilder(this.AppendSegmentToRequestUrl("detectedMalwareState"), this.Client);
            }
        }
    
    }
}
