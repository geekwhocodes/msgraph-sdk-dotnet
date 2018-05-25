// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceExecuteActionRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceExecuteActionRequestBuilder : BaseActionMethodRequestBuilder<IManagedDeviceExecuteActionRequest>, IManagedDeviceExecuteActionRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedDeviceExecuteActionRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="actionName">A actionName parameter for the OData method call.</param>
        /// <param name="deviceIds">A deviceIds parameter for the OData method call.</param>
        public ManagedDeviceExecuteActionRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ManagedDeviceRemoteAction actionName,
            IEnumerable<string> deviceIds)
            : base(requestUrl, client)
        {
            this.SetParameter("actionName", actionName, false);
            this.SetParameter("deviceIds", deviceIds, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedDeviceExecuteActionRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedDeviceExecuteActionRequest(functionUrl, this.Client, options);

            if (this.HasParameter("actionName"))
            {
                request.RequestBody.ActionName = this.GetParameter<ManagedDeviceRemoteAction>("actionName");
            }

            if (this.HasParameter("deviceIds"))
            {
                request.RequestBody.DeviceIds = this.GetParameter<IEnumerable<string>>("deviceIds");
            }

            return request;
        }
    }
}
