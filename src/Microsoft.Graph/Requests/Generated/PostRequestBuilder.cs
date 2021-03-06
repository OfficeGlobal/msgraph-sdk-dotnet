// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PostRequestBuilder.
    /// </summary>
    public partial class PostRequestBuilder : OutlookItemRequestBuilder, IPostRequestBuilder
    {

        /// <summary>
        /// Constructs a new PostRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PostRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPostRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPostRequest Request(IEnumerable<Option> options)
        {
            return new PostRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for InReplyTo.
        /// </summary>
        /// <returns>The <see cref="IPostRequestBuilder"/>.</returns>
        public IPostRequestBuilder InReplyTo
        {
            get
            {
                return new PostRequestBuilder(this.AppendSegmentToRequestUrl("inReplyTo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IPostSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IPostSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new PostSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IPostMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IPostMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new PostMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="IPostExtensionsCollectionRequestBuilder"/>.</returns>
        public IPostExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new PostExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="IPostAttachmentsCollectionRequestBuilder"/>.</returns>
        public IPostAttachmentsCollectionRequestBuilder Attachments
        {
            get
            {
                return new PostAttachmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("attachments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PostReply.
        /// </summary>
        /// <returns>The <see cref="IPostReplyRequestBuilder"/>.</returns>
        public IPostReplyRequestBuilder Reply(
            Post Post)
        {
            return new PostReplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reply"),
                this.Client,
                Post);
        }

        /// <summary>
        /// Gets the request builder for PostForward.
        /// </summary>
        /// <returns>The <see cref="IPostForwardRequestBuilder"/>.</returns>
        public IPostForwardRequestBuilder Forward(
            IEnumerable<Recipient> ToRecipients,
            string Comment = null)
        {
            return new PostForwardRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.forward"),
                this.Client,
                ToRecipients,
                Comment);
        }
    
    }
}
