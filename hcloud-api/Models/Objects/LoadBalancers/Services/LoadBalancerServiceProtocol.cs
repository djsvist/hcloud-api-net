using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers.Services
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoadBalancerServiceProtocol
    {
        Tcp,
        Http,
        Https
    }
}
