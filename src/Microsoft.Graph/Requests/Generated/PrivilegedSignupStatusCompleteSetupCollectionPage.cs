// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type PrivilegedSignupStatusCompleteSetupCollectionPage.
    /// </summary>
    public partial class PrivilegedSignupStatusCompleteSetupCollectionPage : CollectionPage<RoleSuccessStatistics>, IPrivilegedSignupStatusCompleteSetupCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IPrivilegedSignupStatusCompleteSetupRequest"/> instance.
        /// </summary>
        public IPrivilegedSignupStatusCompleteSetupRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new PrivilegedSignupStatusCompleteSetupRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
