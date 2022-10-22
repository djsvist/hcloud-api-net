using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Shared
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IPType
    {
        [EnumMember(Value = "ipv4")]
        IPv4,

        [EnumMember(Value = "ipv6")]
        IPv6
    }
}
