// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceEnrollmentConfigurationRequest.
    /// </summary>
    public partial class DeviceEnrollmentConfigurationRequest : BaseRequest, IDeviceEnrollmentConfigurationRequest
    {
        /// <summary>
        /// Constructs a new DeviceEnrollmentConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceEnrollmentConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <returns>The created DeviceEnrollmentConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> CreateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate)
        {
            return this.CreateAsync(deviceEnrollmentConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceEnrollmentConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToCreate">The DeviceEnrollmentConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> CreateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceEnrollmentConfiguration>(deviceEnrollmentConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceEnrollmentConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <returns>The DeviceEnrollmentConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceEnrollmentConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceEnrollmentConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <returns>The updated DeviceEnrollmentConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> UpdateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate)
        {
            return this.UpdateAsync(deviceEnrollmentConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceEnrollmentConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToUpdate">The DeviceEnrollmentConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceEnrollmentConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceEnrollmentConfiguration> UpdateAsync(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (deviceEnrollmentConfigurationToUpdate.AdditionalData != null)
			{
				if (deviceEnrollmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceEnrollmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceEnrollmentConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (deviceEnrollmentConfigurationToUpdate.AdditionalData != null)
            {
                if (deviceEnrollmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceEnrollmentConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceEnrollmentConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceEnrollmentConfiguration>(deviceEnrollmentConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceEnrollmentConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceEnrollmentConfigurationRequest Expand(Expression<Func<DeviceEnrollmentConfiguration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceEnrollmentConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceEnrollmentConfigurationRequest Select(Expression<Func<DeviceEnrollmentConfiguration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="deviceEnrollmentConfigurationToInitialize">The <see cref="DeviceEnrollmentConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceEnrollmentConfiguration deviceEnrollmentConfigurationToInitialize)
        {

            if (deviceEnrollmentConfigurationToInitialize != null && deviceEnrollmentConfigurationToInitialize.AdditionalData != null)
            {

                if (deviceEnrollmentConfigurationToInitialize.Assignments != null && deviceEnrollmentConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    deviceEnrollmentConfigurationToInitialize.Assignments.AdditionalData = deviceEnrollmentConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceEnrollmentConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceEnrollmentConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
