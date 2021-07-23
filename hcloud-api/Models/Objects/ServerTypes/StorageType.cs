using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.ServerTypes
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageType
    {
        Local,
        Network
    }
}
