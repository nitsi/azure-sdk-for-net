// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteResourceHealthMetadata along with the instance operations that can be performed on it. </summary>
    public partial class SiteResourceHealthMetadata : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteResourceHealthMetadata"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteResourceHealthMetadataResourceHealthMetadataClientDiagnostics;
        private readonly ResourceHealthMetadataRestOperations _siteResourceHealthMetadataResourceHealthMetadataRestClient;
        private readonly ResourceHealthMetadataData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteResourceHealthMetadata"/> class for mocking. </summary>
        protected SiteResourceHealthMetadata()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteResourceHealthMetadata"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteResourceHealthMetadata(ArmClient client, ResourceHealthMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteResourceHealthMetadata"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteResourceHealthMetadata(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteResourceHealthMetadataResourceHealthMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteResourceHealthMetadataResourceHealthMetadataApiVersion);
            _siteResourceHealthMetadataResourceHealthMetadataRestClient = new ResourceHealthMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteResourceHealthMetadataResourceHealthMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/resourceHealthMetadata";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthMetadataData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets the category of ResourceHealthMetadata to use for the given site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default
        /// Operation Id: ResourceHealthMetadata_GetBySite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteResourceHealthMetadata>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteResourceHealthMetadataResourceHealthMetadataClientDiagnostics.CreateScope("SiteResourceHealthMetadata.Get");
            scope.Start();
            try
            {
                var response = await _siteResourceHealthMetadataResourceHealthMetadataRestClient.GetBySiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteResourceHealthMetadata(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the category of ResourceHealthMetadata to use for the given site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/resourceHealthMetadata/default
        /// Operation Id: ResourceHealthMetadata_GetBySite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteResourceHealthMetadata> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteResourceHealthMetadataResourceHealthMetadataClientDiagnostics.CreateScope("SiteResourceHealthMetadata.Get");
            scope.Start();
            try
            {
                var response = _siteResourceHealthMetadataResourceHealthMetadataRestClient.GetBySite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteResourceHealthMetadata(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
