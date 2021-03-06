// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WindowsInformationProtectionNetworkLearningSummary to the collection via POST.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummary">The WindowsInformationProtectionNetworkLearningSummary to add.</param>
        /// <returns>The created WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> AddAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummary);

        /// <summary>
        /// Adds the specified WindowsInformationProtectionNetworkLearningSummary to the collection via POST.
        /// </summary>
        /// <param name="windowsInformationProtectionNetworkLearningSummary">The WindowsInformationProtectionNetworkLearningSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionNetworkLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionNetworkLearningSummary> AddAsync(WindowsInformationProtectionNetworkLearningSummary windowsInformationProtectionNetworkLearningSummary, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Expand(Expression<Func<WindowsInformationProtectionNetworkLearningSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Select(Expression<Func<WindowsInformationProtectionNetworkLearningSummary, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequest OrderBy(string value);
    }
}
