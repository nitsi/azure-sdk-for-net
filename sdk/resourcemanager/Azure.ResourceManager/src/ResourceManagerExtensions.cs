﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager
{
    /// <summary>
    /// Extension class for resource manager.
    /// </summary>
    internal static class ResourceManagerExtensions
    {
        /// <summary>
        /// Gets the correlation id from x-ms-correlation-id.
        /// </summary>
        public static string GetCorrelationId(this Response response)
        {
            string correlationId = null;
            response.Headers.TryGetValue("x-ms-correlation-request-id", out correlationId);
            return correlationId;
        }

        internal static ResourceIdentifier GetSubscriptionResourceIdentifier(this ResourceIdentifier id)
        {
            if (id.ResourceType == Subscription.ResourceType)
                return id;

            ResourceIdentifier parent = id.Parent;
            while (parent != null && parent.ResourceType != Subscription.ResourceType)
            {
                parent = parent.Parent;
            }

            return parent?.ResourceType == Subscription.ResourceType ? parent : null;
        }
    }
}
