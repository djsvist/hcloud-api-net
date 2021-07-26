using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppliedObjectType
    {
        [EnumMember(Value = "server")]
        Server,

        [EnumMember(Value = "label_selector")]
        LabelSelector
    }
}
