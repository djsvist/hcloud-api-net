using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Servers
{
    public class PublicNetwork
    {
        /// <summary>
        /// Firewalls applied to the public network interface of this Server
        /// </summary>
        [JsonProperty("firewalls")]
        public Firewall[] Firewalls { get; set; }

        /// <summary>
        /// IDs of Floating IPs assigned to this Server
        /// </summary>
        [JsonProperty("floating_ips")]
        public int[] FloatingIPs { get; set; }

        /// <summary>
        /// IP address (v4) and its reverse DNS entry of this Server
        /// </summary>
        [JsonProperty("ipv4")]
        public IPv4 IPv4 { get; set; }

        /// <summary>
        /// IPv6 network assigned to this Server and its reverse DNS entry
        /// </summary>
        [JsonProperty("ipv6")]
        public IPv6 IPv6 { get; set; }
    }
}
