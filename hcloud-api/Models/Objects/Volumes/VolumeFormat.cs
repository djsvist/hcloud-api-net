using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Objects.Volumes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VolumeFormat
    {
        [EnumMember(Value = "xfs")]
        XFS,

        [EnumMember(Value = "ext4")]
        EXT4
    }
}
