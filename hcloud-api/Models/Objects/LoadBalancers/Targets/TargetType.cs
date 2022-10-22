using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    /// <summary>
    /// Type of the resource
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetType
    {
        [EnumMember(Value = "server")]
        Server,

        [EnumMember(Value = "label_selector")]
        Label_selector,

        [EnumMember(Value = "ip")]
        ip
    }
}
