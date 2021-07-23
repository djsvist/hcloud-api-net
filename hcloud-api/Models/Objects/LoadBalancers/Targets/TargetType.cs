using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetType
    {
        Server,
        Label_selector,
        ip
    }
}
