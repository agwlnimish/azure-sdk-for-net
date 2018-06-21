// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the update connection operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectionUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionUpdateParameters class.
        /// </summary>
        public ConnectionUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionUpdateParameters class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the connection.</param>
        /// <param name="description">Gets or sets the description of the
        /// connection.</param>
        /// <param name="fieldDefinitionValues">Gets or sets the field
        /// definition values of the connection.</param>
        public ConnectionUpdateParameters(string name = default(string), string description = default(string), IDictionary<string, string> fieldDefinitionValues = default(IDictionary<string, string>))
        {
            Name = name;
            Description = description;
            FieldDefinitionValues = fieldDefinitionValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the connection.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the field definition values of the connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fieldDefinitionValues")]
        public IDictionary<string, string> FieldDefinitionValues { get; set; }

    }
}
