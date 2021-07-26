using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuleDirection
    {
        [EnumMember(Value = "in")]
        In,

        [EnumMember(Value = "out")]
        Out
    }
}
