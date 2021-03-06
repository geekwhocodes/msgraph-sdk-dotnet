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
    /// The interface IWorkbookRangeFormatRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeFormatRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkbookRangeFormatRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkbookRangeFormatRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Borders.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFormatBordersCollectionRequestBuilder"/>.</returns>
        IWorkbookRangeFormatBordersCollectionRequestBuilder Borders { get; }

        /// <summary>
        /// Gets the request builder for Fill.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFillRequestBuilder"/>.</returns>
        IWorkbookRangeFillRequestBuilder Fill { get; }

        /// <summary>
        /// Gets the request builder for Font.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFontRequestBuilder"/>.</returns>
        IWorkbookRangeFontRequestBuilder Font { get; }

        /// <summary>
        /// Gets the request builder for Protection.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFormatProtectionRequestBuilder"/>.</returns>
        IWorkbookFormatProtectionRequestBuilder Protection { get; }
    
        /// <summary>
        /// Gets the request builder for WorkbookRangeFormatAutofitColumns.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFormatAutofitColumnsRequestBuilder"/>.</returns>
        IWorkbookRangeFormatAutofitColumnsRequestBuilder AutofitColumns();

        /// <summary>
        /// Gets the request builder for WorkbookRangeFormatAutofitRows.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeFormatAutofitRowsRequestBuilder"/>.</returns>
        IWorkbookRangeFormatAutofitRowsRequestBuilder AutofitRows();
    
    }
}
