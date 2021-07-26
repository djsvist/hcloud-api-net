using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleProtocol
    {
        [EnumMember(Value = "tcp")]
        TCP,

        [EnumMember(Value = "udp")]
        UDP,

        [EnumMember(Value = "icmp")]
        ICMP,

        [EnumMember(Value = "esp")]
        ESP,

        [EnumMember(Value = "gre")]
        GRE
    }
}
