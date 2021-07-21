using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Servers
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServerStatus
    {
        Running,
        Initializing,
        Starting,
        Stopping,
        Off,
        Deleting,
        migrating,
        Rebuilding,
        Unknown
    }
}
