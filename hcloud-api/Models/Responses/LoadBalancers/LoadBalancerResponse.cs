using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.LoadBalancers
{
    public class LoadBalancerResponse : IResponse
    {
        [JsonProperty("load_balancer")]
        public LoadBalancer LoadBalancer { get; set; }
    }
}
