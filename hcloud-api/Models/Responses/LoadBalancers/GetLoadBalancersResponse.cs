using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.LoadBalancers
{
    public class GetLoadBalancersResponse : IResponse
    {
        [JsonProperty("load_balancers")]
        [JsonRequired]
        public LoadBalancer[] LoadBalancers { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
