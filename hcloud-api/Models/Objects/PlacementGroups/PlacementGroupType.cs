using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.PlacementGroups
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlacementGroupType
    {
        [EnumMember(Value = "spread")]
        Spread
    }
}
