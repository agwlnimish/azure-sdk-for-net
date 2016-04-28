// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Graph.RBAC.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Active Directory group information
    /// </summary>
    public partial class ADGroup
    {
        /// <summary>
        /// Initializes a new instance of the ADGroup class.
        /// </summary>
        public ADGroup() { }

        /// <summary>
        /// Initializes a new instance of the ADGroup class.
        /// </summary>
        public ADGroup(string objectId = default(string), string objectType = default(string), string displayName = default(string), bool? securityEnabled = default(bool?), string mail = default(string))
        {
            ObjectId = objectId;
            ObjectType = objectType;
            DisplayName = displayName;
            SecurityEnabled = securityEnabled;
            Mail = mail;
        }

        /// <summary>
        /// Gets or sets object Id
        /// </summary>
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or sets object type
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets group display name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets security enabled field
        /// </summary>
        [JsonProperty(PropertyName = "securityEnabled")]
        public bool? SecurityEnabled { get; set; }

        /// <summary>
        /// Gets or sets mail field
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

    }
}