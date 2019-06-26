// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ConsumerGroupsOperations operations.
    /// </summary>
    public partial interface IConsumerGroupsOperations
    {
        /// <summary>
        /// Creates or updates an Event Hubs consumer group as a nested
        /// resource within a Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='userMetadata'>
        /// User Metadata is a placeholder to store user-defined string data
        /// with maximum length 1024. e.g. it can be used to store descriptive
        /// data, such as list of teams and their contact information also
        /// user-defined configuration settings can be stored.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConsumerGroupInner>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, string userMetadata = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a consumer group from the specified Event Hub and resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a description for the specified consumer group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='consumerGroupName'>
        /// The consumer group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConsumerGroupInner>> GetWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, string consumerGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of the resource group within the azure subscription.
        /// </param>
        /// <param name='namespaceName'>
        /// The Namespace name
        /// </param>
        /// <param name='eventHubName'>
        /// The Event Hub name
        /// </param>
        /// <param name='skip'>
        /// Skip is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skip parameter that
        /// specifies a starting point to use for subsequent calls.
        /// </param>
        /// <param name='top'>
        /// May be used to limit the number of results to the most recent N
        /// usageDetails.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ConsumerGroupInner>>> ListByEventHubWithHttpMessagesAsync(string resourceGroupName, string namespaceName, string eventHubName, int? skip = default(int?), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the consumer groups in a Namespace. An empty feed is
        /// returned if no consumer group exists in the Namespace.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ConsumerGroupInner>>> ListByEventHubNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
