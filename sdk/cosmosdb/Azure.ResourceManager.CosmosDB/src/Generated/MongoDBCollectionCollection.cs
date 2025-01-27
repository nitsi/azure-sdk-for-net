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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of MongoDBCollection and their operations over its parent. </summary>
    public partial class MongoDBCollectionCollection : ArmCollection, IEnumerable<MongoDBCollection>, IAsyncEnumerable<MongoDBCollection>
    {
        private readonly ClientDiagnostics _mongoDBCollectionMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBCollectionMongoDBResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoDBCollectionCollection"/> class for mocking. </summary>
        protected MongoDBCollectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBCollectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoDBCollectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBCollectionMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoDBCollection.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MongoDBCollection.ResourceType, out string mongoDBCollectionMongoDBResourcesApiVersion);
            _mongoDBCollectionMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoDBCollectionMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MongoDBDatabase.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MongoDBDatabase.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an Azure Cosmos DB MongoDB Collection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_CreateUpdateMongoDBCollection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="createUpdateMongoDBCollectionParameters"> The parameters to provide for the current MongoDB Collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> or <paramref name="createUpdateMongoDBCollectionParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoDBCollection>> CreateOrUpdateAsync(WaitUntil waitUntil, string collectionName, MongoDBCollectionCreateUpdateData createUpdateMongoDBCollectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));
            Argument.AssertNotNull(createUpdateMongoDBCollectionParameters, nameof(createUpdateMongoDBCollectionParameters));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoDBCollectionMongoDBResourcesRestClient.CreateUpdateMongoDBCollectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, createUpdateMongoDBCollectionParameters, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoDBCollection>(new MongoDBCollectionOperationSource(Client), _mongoDBCollectionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBCollectionMongoDBResourcesRestClient.CreateCreateUpdateMongoDBCollectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, createUpdateMongoDBCollectionParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an Azure Cosmos DB MongoDB Collection
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_CreateUpdateMongoDBCollection
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="createUpdateMongoDBCollectionParameters"> The parameters to provide for the current MongoDB Collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> or <paramref name="createUpdateMongoDBCollectionParameters"/> is null. </exception>
        public virtual ArmOperation<MongoDBCollection> CreateOrUpdate(WaitUntil waitUntil, string collectionName, MongoDBCollectionCreateUpdateData createUpdateMongoDBCollectionParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));
            Argument.AssertNotNull(createUpdateMongoDBCollectionParameters, nameof(createUpdateMongoDBCollectionParameters));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoDBCollectionMongoDBResourcesRestClient.CreateUpdateMongoDBCollection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, createUpdateMongoDBCollectionParameters, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoDBCollection>(new MongoDBCollectionOperationSource(Client), _mongoDBCollectionMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBCollectionMongoDBResourcesRestClient.CreateCreateUpdateMongoDBCollectionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, createUpdateMongoDBCollectionParameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the MongoDB collection under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual async Task<Response<MongoDBCollection>> GetAsync(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBCollectionMongoDBResourcesRestClient.GetMongoDBCollectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBCollection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the MongoDB collection under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual Response<MongoDBCollection> Get(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoDBCollectionMongoDBResourcesRestClient.GetMongoDBCollection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBCollection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the MongoDB collection under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections
        /// Operation Id: MongoDBResources_ListMongoDBCollections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoDBCollection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MongoDBCollection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mongoDBCollectionMongoDBResourcesRestClient.ListMongoDBCollectionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MongoDBCollection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists the MongoDB collection under an existing Azure Cosmos DB database account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections
        /// Operation Id: MongoDBResources_ListMongoDBCollections
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoDBCollection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MongoDBCollection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mongoDBCollectionMongoDBResourcesRestClient.ListMongoDBCollections(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MongoDBCollection(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(collectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(collectionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual async Task<Response<MongoDBCollection>> GetIfExistsAsync(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoDBCollectionMongoDBResourcesRestClient.GetMongoDBCollectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<MongoDBCollection>(null, response.GetRawResponse());
                return Response.FromValue(new MongoDBCollection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
        /// Operation Id: MongoDBResources_GetMongoDBCollection
        /// </summary>
        /// <param name="collectionName"> Cosmos DB collection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="collectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="collectionName"/> is null. </exception>
        public virtual Response<MongoDBCollection> GetIfExists(string collectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(collectionName, nameof(collectionName));

            using var scope = _mongoDBCollectionMongoDBResourcesClientDiagnostics.CreateScope("MongoDBCollectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoDBCollectionMongoDBResourcesRestClient.GetMongoDBCollection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, collectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<MongoDBCollection>(null, response.GetRawResponse());
                return Response.FromValue(new MongoDBCollection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoDBCollection> IEnumerable<MongoDBCollection>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoDBCollection> IAsyncEnumerable<MongoDBCollection>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
