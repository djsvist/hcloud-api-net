using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Requests.Servers.Actions
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RescueType
    {
        [EnumMember(Value = "linux64")]
        Linux64,

        [EnumMember(Value = "linux32")]
        Linux32,

        [EnumMember(Value = "freebsd64")]
        FreeBSD64
    }
}
