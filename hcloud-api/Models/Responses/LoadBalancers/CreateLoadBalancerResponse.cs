using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.LoadBalancers
{
    public class CreateLoadBalancerResponse : ActionResponse
    {
        [JsonProperty("load_balancer")]
        public LoadBalancer LoadBalancer { get; set; }
    }
}
