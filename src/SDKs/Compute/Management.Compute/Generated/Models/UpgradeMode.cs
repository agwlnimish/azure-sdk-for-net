// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UpgradeMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpgradeMode
    {
        [EnumMember(Value = "Automatic")]
        Automatic,
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Rolling")]
        Rolling
    }
    internal static class UpgradeModeEnumExtension
    {
        internal static string ToSerializedValue(this UpgradeMode? value)
        {
            return value == null ? null : ((UpgradeMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this UpgradeMode value)
        {
            switch( value )
            {
                case UpgradeMode.Automatic:
                    return "Automatic";
                case UpgradeMode.Manual:
                    return "Manual";
                case UpgradeMode.Rolling:
                    return "Rolling";
            }
            return null;
        }

        internal static UpgradeMode? ParseUpgradeMode(this string value)
        {
            switch( value )
            {
                case "Automatic":
                    return UpgradeMode.Automatic;
                case "Manual":
                    return UpgradeMode.Manual;
                case "Rolling":
                    return UpgradeMode.Rolling;
            }
            return null;
        }
    }
}
