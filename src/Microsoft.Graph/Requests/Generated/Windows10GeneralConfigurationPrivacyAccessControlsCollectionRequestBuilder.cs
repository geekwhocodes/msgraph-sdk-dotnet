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
    /// The type Windows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder.
    /// </summary>
    public partial class Windows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder : BaseRequestBuilder, IWindows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new Windows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public Windows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindows10GeneralConfigurationPrivacyAccessControlsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindows10GeneralConfigurationPrivacyAccessControlsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new Windows10GeneralConfigurationPrivacyAccessControlsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsPrivacyDataAccessControlItemRequestBuilder"/> for the specified Windows10GeneralConfigurationWindowsPrivacyDataAccessControlItem.
        /// </summary>
        /// <param name="id">The ID for the Windows10GeneralConfigurationWindowsPrivacyDataAccessControlItem.</param>
        /// <returns>The <see cref="IWindowsPrivacyDataAccessControlItemRequestBuilder"/>.</returns>
        public IWindowsPrivacyDataAccessControlItemRequestBuilder this[string id]
        {
            get
            {
                return new WindowsPrivacyDataAccessControlItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
