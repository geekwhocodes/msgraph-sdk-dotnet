// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOutlookTaskRequestBuilder.
    /// </summary>
    public partial interface IOutlookTaskRequestBuilder : IOutlookItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOutlookTaskRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOutlookTaskRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IOutlookTaskSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        IOutlookTaskMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskAttachmentsCollectionRequestBuilder"/>.</returns>
        IOutlookTaskAttachmentsCollectionRequestBuilder Attachments { get; }
    
        /// <summary>
        /// Gets the request builder for OutlookTaskComplete.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskCompleteRequestBuilder"/>.</returns>
        IOutlookTaskCompleteRequestBuilder Complete();
    
    }
}
