// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Tenant Id information.
    /// </summary>
    public partial class TenantIdDescription
    {
        /// <summary>
        /// Initializes a new instance of the TenantIdDescription class.
        /// </summary>
        public TenantIdDescription() { }

        /// <summary>
        /// Initializes a new instance of the TenantIdDescription class.
        /// </summary>
        /// <param name="id">The Id.</param>
        /// <param name="tenantId">The tenantId.</param>
        public TenantIdDescription(string id = default(string), string tenantId = default(string))
        {
            Id = id;
            TenantId = tenantId;
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tenantId.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

    }
}