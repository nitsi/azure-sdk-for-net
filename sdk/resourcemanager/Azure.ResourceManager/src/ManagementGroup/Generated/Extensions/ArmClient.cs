// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Management;

namespace Azure.ResourceManager
{
    public partial class ArmClient
    {
        #region ManagementGroup
        /// <summary>
        /// Gets an object representing a <see cref="ManagementGroup" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementGroup.CreateResourceIdentifier" /> to create a <see cref="ManagementGroup" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroup" /> object. </returns>
        public virtual ManagementGroup GetManagementGroup(ResourceIdentifier id)
        {
            ManagementGroup.ValidateResourceId(id);
            return new ManagementGroup(this, id);
        }
        #endregion
    }
}
