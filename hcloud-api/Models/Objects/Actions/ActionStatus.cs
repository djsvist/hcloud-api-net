using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Actions
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionStatus
    {
        Success,
        Running,
        Error
    }
}
