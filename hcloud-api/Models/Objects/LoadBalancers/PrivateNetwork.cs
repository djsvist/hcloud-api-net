using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    public class PrivateNetwork
    {
        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("network")]
        public int Network { get; set; }
    }
}
