using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppliedResourceType
    {
        [EnumMember(Value = "server")]
        Server
    }
}
