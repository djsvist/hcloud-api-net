using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers.HealthChecks
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HealthCheckProtocol
    {
        Tcp,
        Http
    }
}
