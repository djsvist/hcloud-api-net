using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Images
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OsFlavor
    {
        Ubuntu,
        Centos,
        Debian,
        Fedora,
        Unknown,
        Rocky
    }
}
