using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.ISOs
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ISOType
    {
        Public,
        Private
    }
}
