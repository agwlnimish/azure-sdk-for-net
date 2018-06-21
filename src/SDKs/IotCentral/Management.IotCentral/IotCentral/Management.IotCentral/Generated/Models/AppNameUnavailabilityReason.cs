// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotCentral.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AppNameUnavailabilityReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppNameUnavailabilityReason
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "AlreadyExists")]
        AlreadyExists
    }
    internal static class AppNameUnavailabilityReasonEnumExtension
    {
        internal static string ToSerializedValue(this AppNameUnavailabilityReason? value)
        {
            return value == null ? null : ((AppNameUnavailabilityReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AppNameUnavailabilityReason value)
        {
            switch( value )
            {
                case AppNameUnavailabilityReason.Invalid:
                    return "Invalid";
                case AppNameUnavailabilityReason.AlreadyExists:
                    return "AlreadyExists";
            }
            return null;
        }

        internal static AppNameUnavailabilityReason? ParseAppNameUnavailabilityReason(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return AppNameUnavailabilityReason.Invalid;
                case "AlreadyExists":
                    return AppNameUnavailabilityReason.AlreadyExists;
            }
            return null;
        }
    }
}
