using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.LoadBalancerTypes
{
    public class GetLoadBalancerTypeResponse : IResponse
    {
        [JsonProperty("load_balancer_type")]
        public LoadBalancerType LoadBalancerType { get; set; }
    }
}
