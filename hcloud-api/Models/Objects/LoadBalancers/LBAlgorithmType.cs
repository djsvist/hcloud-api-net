using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LBAlgorithmType
    {
        Round_robin,
        Least_connections
    }
}
