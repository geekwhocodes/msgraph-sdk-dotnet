// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOutlookUserTasksCollectionRequestBuilder.
    /// </summary>
    public partial interface IOutlookUserTasksCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOutlookUserTasksCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOutlookUserTasksCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IOutlookTaskRequestBuilder"/> for the specified OutlookTask.
        /// </summary>
        /// <param name="id">The ID for the OutlookTask.</param>
        /// <returns>The <see cref="IOutlookTaskRequestBuilder"/>.</returns>
        IOutlookTaskRequestBuilder this[string id] { get; }

        
    }
}
