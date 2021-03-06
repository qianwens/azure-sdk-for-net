// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LoginType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoginType
    {
        [EnumMember(Value = "WindowsUser")]
        WindowsUser,
        [EnumMember(Value = "WindowsGroup")]
        WindowsGroup,
        [EnumMember(Value = "SqlLogin")]
        SqlLogin,
        [EnumMember(Value = "Certificate")]
        Certificate,
        [EnumMember(Value = "AsymmetricKey")]
        AsymmetricKey,
        [EnumMember(Value = "ExternalUser")]
        ExternalUser,
        [EnumMember(Value = "ExternalGroup")]
        ExternalGroup
    }
    internal static class LoginTypeEnumExtension
    {
        internal static string ToSerializedValue(this LoginType? value)
        {
            return value == null ? null : ((LoginType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LoginType value)
        {
            switch( value )
            {
                case LoginType.WindowsUser:
                    return "WindowsUser";
                case LoginType.WindowsGroup:
                    return "WindowsGroup";
                case LoginType.SqlLogin:
                    return "SqlLogin";
                case LoginType.Certificate:
                    return "Certificate";
                case LoginType.AsymmetricKey:
                    return "AsymmetricKey";
                case LoginType.ExternalUser:
                    return "ExternalUser";
                case LoginType.ExternalGroup:
                    return "ExternalGroup";
            }
            return null;
        }

        internal static LoginType? ParseLoginType(this string value)
        {
            switch( value )
            {
                case "WindowsUser":
                    return LoginType.WindowsUser;
                case "WindowsGroup":
                    return LoginType.WindowsGroup;
                case "SqlLogin":
                    return LoginType.SqlLogin;
                case "Certificate":
                    return LoginType.Certificate;
                case "AsymmetricKey":
                    return LoginType.AsymmetricKey;
                case "ExternalUser":
                    return LoginType.ExternalUser;
                case "ExternalGroup":
                    return LoginType.ExternalGroup;
            }
            return null;
        }
    }
}
