using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.PrimaryIPs
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssigneeType
    {
        [EnumMember(Value = "server")]
        Server
    }
}
