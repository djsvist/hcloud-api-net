using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Networks
{
    /// <summary>
    /// Type of Subnetwork
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubnetType
    {
        [EnumMember(Value = "cloud")]
        Cloud,

        [EnumMember(Value = "server")]
        Server,

        [EnumMember(Value = "vswitch")]
        VSwitch
    }
}
