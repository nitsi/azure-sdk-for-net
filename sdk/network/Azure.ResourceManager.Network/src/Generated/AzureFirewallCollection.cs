// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of AzureFirewall and their operations over its parent. </summary>
    public partial class AzureFirewallCollection : ArmCollection, IEnumerable<AzureFirewall>, IAsyncEnumerable<AzureFirewall>
    {
        private readonly ClientDiagnostics _azureFirewallClientDiagnostics;
        private readonly AzureFirewallsRestOperations _azureFirewallRestClient;

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class for mocking. </summary>
        protected AzureFirewallCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AzureFirewallCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AzureFirewallCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _azureFirewallClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", AzureFirewall.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AzureFirewall.ResourceType, out string azureFirewallApiVersion);
            _azureFirewallRestClient = new AzureFirewallsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, azureFirewallApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified Azure Firewall.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<AzureFirewall>> CreateOrUpdateAsync(WaitUntil waitUntil, string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<AzureFirewall>(new AzureFirewallOperationSource(Client), _azureFirewallClientDiagnostics, Pipeline, _azureFirewallRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the specified Azure Firewall.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Azure Firewall operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<AzureFirewall> CreateOrUpdate(WaitUntil waitUntil, string azureFirewallName, AzureFirewallData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<AzureFirewall>(new AzureFirewallOperationSource(Client), _azureFirewallClientDiagnostics, Pipeline, _azureFirewallRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Firewall.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<Response<AzureFirewall>> GetAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Azure Firewall.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<AzureFirewall> Get(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Get");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Azure Firewalls in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls
        /// Operation Id: AzureFirewalls_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureFirewall> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureFirewall>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _azureFirewallRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AzureFirewall>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _azureFirewallRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all Azure Firewalls in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls
        /// Operation Id: AzureFirewalls_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureFirewall" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureFirewall> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AzureFirewall> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _azureFirewallRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AzureFirewall> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _azureFirewallRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AzureFirewall(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<bool> Exists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(azureFirewallName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual async Task<Response<AzureFirewall>> GetIfExistsAsync(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _azureFirewallRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AzureFirewall>(null, response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
        /// Operation Id: AzureFirewalls_Get
        /// </summary>
        /// <param name="azureFirewallName"> The name of the Azure Firewall. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="azureFirewallName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="azureFirewallName"/> is null. </exception>
        public virtual Response<AzureFirewall> GetIfExists(string azureFirewallName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(azureFirewallName, nameof(azureFirewallName));

            using var scope = _azureFirewallClientDiagnostics.CreateScope("AzureFirewallCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _azureFirewallRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, azureFirewallName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AzureFirewall>(null, response.GetRawResponse());
                return Response.FromValue(new AzureFirewall(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AzureFirewall> IEnumerable<AzureFirewall>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AzureFirewall> IAsyncEnumerable<AzureFirewall>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
