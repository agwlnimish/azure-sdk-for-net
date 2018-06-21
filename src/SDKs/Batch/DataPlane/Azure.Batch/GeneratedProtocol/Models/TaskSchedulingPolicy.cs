// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies how tasks should be distributed across compute nodes.
    /// </summary>
    public partial class TaskSchedulingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        public TaskSchedulingPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        /// <param name="nodeFillType">How tasks are distributed across compute
        /// nodes in a pool.</param>
        public TaskSchedulingPolicy(ComputeNodeFillType nodeFillType)
        {
            NodeFillType = nodeFillType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets how tasks are distributed across compute nodes in a
        /// pool.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'spread', 'pack'
        /// </remarks>
        [JsonProperty(PropertyName = "nodeFillType")]
        public ComputeNodeFillType NodeFillType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
