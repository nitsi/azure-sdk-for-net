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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryImage and their operations over its parent. </summary>
    public partial class GalleryImageCollection : ArmCollection, IEnumerable<GalleryImage>, IAsyncEnumerable<GalleryImage>
    {
        private readonly ClientDiagnostics _galleryImageClientDiagnostics;
        private readonly GalleryImagesRestOperations _galleryImageRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryImageCollection"/> class for mocking. </summary>
        protected GalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryImageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryImage.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GalleryImage.ResourceType, out string galleryImageApiVersion);
            _galleryImageRestClient = new GalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, galleryImageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Gallery.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Gallery.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryImage>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNull(galleryImage, nameof(galleryImage));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryImageRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryImage>(new GalleryImageOperationSource(Client), _galleryImageClientDiagnostics, Pipeline, _galleryImageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual ArmOperation<GalleryImage> CreateOrUpdate(WaitUntil waitUntil, string galleryImageName, GalleryImageData galleryImage, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));
            Argument.AssertNotNull(galleryImage, nameof(galleryImage));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryImageRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken);
                var operation = new ComputeArmOperation<GalleryImage>(new GalleryImageOperationSource(Client), _galleryImageClientDiagnostics, Pipeline, _galleryImageRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<GalleryImage>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryImageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<GalleryImage> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryImageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery image definitions in a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images
        /// Operation Id: GalleryImages_ListByGallery
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImage> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImageRestClient.ListByGalleryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImageRestClient.ListByGalleryNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List gallery image definitions in a gallery.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images
        /// Operation Id: GalleryImages_ListByGallery
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImage> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImageRestClient.ListByGallery(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImageRestClient.ListByGalleryNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryImageName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual async Task<Response<GalleryImage>> GetIfExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryImageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GalleryImage>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}
        /// Operation Id: GalleryImages_Get
        /// </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> is null. </exception>
        public virtual Response<GalleryImage> GetIfExists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageName, nameof(galleryImageName));

            using var scope = _galleryImageClientDiagnostics.CreateScope("GalleryImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryImageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GalleryImage>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryImage> IEnumerable<GalleryImage>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryImage> IAsyncEnumerable<GalleryImage>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
