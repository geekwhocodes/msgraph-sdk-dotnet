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
    /// The type SecurityRequestBuilder.
    /// </summary>
    public partial class SecurityRequestBuilder : EntityRequestBuilder, ISecurityRequestBuilder
    {

        /// <summary>
        /// Constructs a new SecurityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISecurityRequest Request(IEnumerable<Option> options)
        {
            return new SecurityRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Alerts.
        /// </summary>
        /// <returns>The <see cref="ISecurityAlertsCollectionRequestBuilder"/>.</returns>
        public ISecurityAlertsCollectionRequestBuilder Alerts
        {
            get
            {
                return new SecurityAlertsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("alerts"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ApplicationSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityApplicationSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityApplicationSecurityProfilesCollectionRequestBuilder ApplicationSecurityProfiles
        {
            get
            {
                return new SecurityApplicationSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("applicationSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FileSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityFileSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityFileSecurityProfilesCollectionRequestBuilder FileSecurityProfiles
        {
            get
            {
                return new SecurityFileSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("fileSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HostSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityHostSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityHostSecurityProfilesCollectionRequestBuilder HostSecurityProfiles
        {
            get
            {
                return new SecurityHostSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("hostSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IpSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityIpSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityIpSecurityProfilesCollectionRequestBuilder IpSecurityProfiles
        {
            get
            {
                return new SecurityIpSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("ipSecurityProfiles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserSecurityProfiles.
        /// </summary>
        /// <returns>The <see cref="ISecurityUserSecurityProfilesCollectionRequestBuilder"/>.</returns>
        public ISecurityUserSecurityProfilesCollectionRequestBuilder UserSecurityProfiles
        {
            get
            {
                return new SecurityUserSecurityProfilesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userSecurityProfiles"), this.Client);
            }
        }
    
    }
}
