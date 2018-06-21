// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Filter and return results from input array based on the conditions.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Filter")]
    [Rest.Serialization.JsonTransformation]
    public partial class FilterActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the FilterActivity class.
        /// </summary>
        public FilterActivity()
        {
            Items = new Expression();
            Condition = new Expression();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FilterActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="items">Input array on which filter should be
        /// applied.</param>
        /// <param name="condition">Condition to be used for filtering the
        /// input.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        public FilterActivity(string name, Expression items, Expression condition, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>))
            : base(name, additionalProperties, description, dependsOn)
        {
            Items = items;
            Condition = condition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets input array on which filter should be applied.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.items")]
        public Expression Items { get; set; }

        /// <summary>
        /// Gets or sets condition to be used for filtering the input.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.condition")]
        public Expression Condition { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Items == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Items");
            }
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
            if (Items != null)
            {
                Items.Validate();
            }
            if (Condition != null)
            {
                Condition.Validate();
            }
        }
    }
}
