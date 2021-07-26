using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.LoadBalancerTypes
{
    public class GetLoadBalancerTypesResponse : IResponse
    {
        [JsonProperty("load_balancer_types")]
        public LoadBalancerType[] LoadBalancerTypes { get; set; }
    }
}
