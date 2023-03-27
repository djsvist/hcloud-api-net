using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Volumes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VolumeStatus
    {
        [EnumMember(Value = "creating")]
        Creating,

        [EnumMember(Value = "available")]
        Available
    }
}
