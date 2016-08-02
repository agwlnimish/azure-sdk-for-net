// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error that occurred when executing or evaluating a pool autoscale formula.
    /// </summary>
    public partial class AutoScaleRunError : IPropertyMetadata
    {
        private readonly string code;
        private readonly string message;
        private readonly IReadOnlyList<NameValuePair> values;

        #region Constructors

        internal AutoScaleRunError(Models.AutoScaleRunError protocolObject)
        {
            this.code = protocolObject.Code;
            this.message = protocolObject.Message;
            this.values = NameValuePair.ConvertFromProtocolCollectionReadOnly(protocolObject.Values);
        }

        #endregion Constructors

        #region AutoScaleRunError

        /// <summary>
        /// Gets a code for the autoscale error. See <see cref="Common.BatchErrorCodeStrings"/> for possible values.
        /// </summary>
        public string Code
        {
            get { return this.code; }
        }

        /// <summary>
        /// Gets a message describing the autoscale error, intended to be suitable for display in a user interface.
        /// </summary>
        public string Message
        {
            get { return this.message; }
        }

        /// <summary>
        /// Gets a list of additional error details related to the autoscale error.
        /// </summary>
        public IReadOnlyList<NameValuePair> Values
        {
            get { return this.values; }
        }

        #endregion // AutoScaleRunError

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}