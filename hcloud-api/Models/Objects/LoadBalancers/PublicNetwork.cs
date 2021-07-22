using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    public class PublicNetwork
    {
        /// <summary>
        /// Public Interface enabled or not
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// IP address (v4)
        /// </summary>
        [JsonProperty("ipv4")]
        public IPInfo IPv4 { get; set; }

        /// <summary>
        /// IP address (v6)
        /// </summary>
        [JsonProperty("ipv6")]
        public IPInfo IPv6 { get; set; }
    }
}
