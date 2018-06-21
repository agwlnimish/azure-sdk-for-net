// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Product Update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProductUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ProductUpdateParameters class.
        /// </summary>
        public ProductUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductUpdateParameters class.
        /// </summary>
        /// <param name="description">Product description. May include HTML
        /// formatting tags.</param>
        /// <param name="terms">Product terms of use. Developers trying to
        /// subscribe to the product will be presented and required to accept
        /// these terms before they can complete the subscription
        /// process.</param>
        /// <param name="subscriptionRequired">Whether a product subscription
        /// is required for accessing APIs included in this product. If true,
        /// the product is referred to as "protected" and a valid subscription
        /// key is required for a request to an API included in the product to
        /// succeed. If false, the product is referred to as "open" and
        /// requests to an API included in the product can be made without a
        /// subscription key. If property is omitted when creating a new
        /// product it's value is assumed to be true.</param>
        /// <param name="approvalRequired">whether subscription approval is
        /// required. If false, new subscriptions will be approved
        /// automatically enabling developers to call the product’s APIs
        /// immediately after subscribing. If true, administrators must
        /// manually approve the subscription before the developer can any of
        /// the product’s APIs. Can be present only if subscriptionRequired
        /// property is present and has a value of false.</param>
        /// <param name="subscriptionsLimit">Whether the number of
        /// subscriptions a user can have to this product at the same time. Set
        /// to null or omit to allow unlimited per user subscriptions. Can be
        /// present only if subscriptionRequired property is present and has a
        /// value of false.</param>
        /// <param name="state">whether product is published or not. Published
        /// products are discoverable by users of developer portal. Non
        /// published products are visible only to administrators. Default
        /// state of Product is notPublished. Possible values include:
        /// 'notPublished', 'published'</param>
        /// <param name="displayName">Product name.</param>
        public ProductUpdateParameters(string description = default(string), string terms = default(string), bool? subscriptionRequired = default(bool?), bool? approvalRequired = default(bool?), int? subscriptionsLimit = default(int?), ProductState? state = default(ProductState?), string displayName = default(string))
        {
            Description = description;
            Terms = terms;
            SubscriptionRequired = subscriptionRequired;
            ApprovalRequired = approvalRequired;
            SubscriptionsLimit = subscriptionsLimit;
            State = state;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets product description. May include HTML formatting tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets product terms of use. Developers trying to subscribe
        /// to the product will be presented and required to accept these terms
        /// before they can complete the subscription process.
        /// </summary>
        [JsonProperty(PropertyName = "properties.terms")]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or sets whether a product subscription is required for
        /// accessing APIs included in this product. If true, the product is
        /// referred to as "protected" and a valid subscription key is required
        /// for a request to an API included in the product to succeed. If
        /// false, the product is referred to as "open" and requests to an API
        /// included in the product can be made without a subscription key. If
        /// property is omitted when creating a new product it's value is
        /// assumed to be true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionRequired")]
        public bool? SubscriptionRequired { get; set; }

        /// <summary>
        /// Gets or sets whether subscription approval is required. If false,
        /// new subscriptions will be approved automatically enabling
        /// developers to call the product’s APIs immediately after
        /// subscribing. If true, administrators must manually approve the
        /// subscription before the developer can any of the product’s APIs.
        /// Can be present only if subscriptionRequired property is present and
        /// has a value of false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.approvalRequired")]
        public bool? ApprovalRequired { get; set; }

        /// <summary>
        /// Gets or sets whether the number of subscriptions a user can have to
        /// this product at the same time. Set to null or omit to allow
        /// unlimited per user subscriptions. Can be present only if
        /// subscriptionRequired property is present and has a value of false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionsLimit")]
        public int? SubscriptionsLimit { get; set; }

        /// <summary>
        /// Gets or sets whether product is published or not. Published
        /// products are discoverable by users of developer portal. Non
        /// published products are visible only to administrators. Default
        /// state of Product is notPublished. Possible values include:
        /// 'notPublished', 'published'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public ProductState? State { get; set; }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description != null)
            {
                if (Description.Length > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 1000);
                }
                if (Description.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 1);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 300);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
            }
        }
    }
}
