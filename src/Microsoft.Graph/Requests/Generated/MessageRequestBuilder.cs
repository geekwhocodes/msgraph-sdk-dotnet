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
    /// The type MessageRequestBuilder.
    /// </summary>
    public partial class MessageRequestBuilder : OutlookItemRequestBuilder, IMessageRequestBuilder
    {

        /// <summary>
        /// Constructs a new MessageRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MessageRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMessageRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMessageRequest Request(IEnumerable<Option> options)
        {
            return new MessageRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IMessageAttachmentsCollectionRequestBuilder"/>.</returns>
        public IMessageAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new MessageAttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IMessageExtensionsCollectionRequestBuilder"/>.</returns>
        public IMessageExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new MessageExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMessageSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IMessageSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new MessageSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMessageMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IMessageMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new MessageMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Mentions.
        /// </summary>
        /// <returns>The <see cref="IMessageMentionsCollectionRequestBuilder"/>.</returns>
        public IMessageMentionsCollectionRequestBuilder Mentions
        {
            get
            {
                return new MessageMentionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("mentions"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for MessageCopy.
        /// </summary>
        /// <returns>The <see cref="IMessageCopyRequestBuilder"/>.</returns>
        public IMessageCopyRequestBuilder Copy(
            string DestinationId = null)
        {
            return new MessageCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copy"),
                this.Client,
                DestinationId);
        }

        /// <summary>
        /// Gets the request builder for MessageMove.
        /// </summary>
        /// <returns>The <see cref="IMessageMoveRequestBuilder"/>.</returns>
        public IMessageMoveRequestBuilder Move(
            string DestinationId = null)
        {
            return new MessageMoveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.move"),
                this.Client,
                DestinationId);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateReply.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateReplyRequestBuilder"/>.</returns>
        public IMessageCreateReplyRequestBuilder CreateReply(
            Message Message = null,
            string Comment = null)
        {
            return new MessageCreateReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createReply"),
                this.Client,
                Message,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateReplyAll.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateReplyAllRequestBuilder"/>.</returns>
        public IMessageCreateReplyAllRequestBuilder CreateReplyAll(
            Message Message = null,
            string Comment = null)
        {
            return new MessageCreateReplyAllRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createReplyAll"),
                this.Client,
                Message,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageCreateForward.
        /// </summary>
        /// <returns>The <see cref="IMessageCreateForwardRequestBuilder"/>.</returns>
        public IMessageCreateForwardRequestBuilder CreateForward(
            Message Message = null,
            string Comment = null,
            IEnumerable<Recipient> ToRecipients = null)
        {
            return new MessageCreateForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createForward"),
                this.Client,
                Message,
                Comment,
                ToRecipients);
        }

        /// <summary>
        /// Gets the request builder for MessageReply.
        /// </summary>
        /// <returns>The <see cref="IMessageReplyRequestBuilder"/>.</returns>
        public IMessageReplyRequestBuilder Reply(
            Message Message = null,
            string Comment = null)
        {
            return new MessageReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reply"),
                this.Client,
                Message,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageReplyAll.
        /// </summary>
        /// <returns>The <see cref="IMessageReplyAllRequestBuilder"/>.</returns>
        public IMessageReplyAllRequestBuilder ReplyAll(
            Message Message = null,
            string Comment = null)
        {
            return new MessageReplyAllRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.replyAll"),
                this.Client,
                Message,
                Comment);
        }

        /// <summary>
        /// Gets the request builder for MessageForward.
        /// </summary>
        /// <returns>The <see cref="IMessageForwardRequestBuilder"/>.</returns>
        public IMessageForwardRequestBuilder Forward(
            Message Message = null,
            string Comment = null,
            IEnumerable<Recipient> ToRecipients = null)
        {
            return new MessageForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.forward"),
                this.Client,
                Message,
                Comment,
                ToRecipients);
        }

        /// <summary>
        /// Gets the request builder for MessageSend.
        /// </summary>
        /// <returns>The <see cref="IMessageSendRequestBuilder"/>.</returns>
        public IMessageSendRequestBuilder Send()
        {
            return new MessageSendRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.send"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for MessageUnsubscribe.
        /// </summary>
        /// <returns>The <see cref="IMessageUnsubscribeRequestBuilder"/>.</returns>
        public IMessageUnsubscribeRequestBuilder Unsubscribe()
        {
            return new MessageUnsubscribeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unsubscribe"),
                this.Client);
        }
    
    }
}
