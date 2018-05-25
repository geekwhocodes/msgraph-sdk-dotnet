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
    /// The type DeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceConfigurationRestrictedAppsViolationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRestrictedAppsViolationRequestBuilder"/> for the specified DeviceManagementRestrictedAppsViolation.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementRestrictedAppsViolation.</param>
        /// <returns>The <see cref="IRestrictedAppsViolationRequestBuilder"/>.</returns>
        public IRestrictedAppsViolationRequestBuilder this[string id]
        {
            get
            {
                return new RestrictedAppsViolationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
