using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Servers
{
    public class IPv4
    {
        /// <summary>
        /// If the IP is blocked by our anti abuse dept
        /// </summary>
        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        /// <summary>
        /// Reverse DNS PTR entry for the IPv4 addresses of this Server
        /// </summary>
        [JsonProperty("dns_ptr")]
        public string DNSPTR { get; set; }

        /// <summary>
        /// IP address (v4) of this Server
        /// </summary>
        [JsonProperty("ip")]
        public string IP { get; set; }
    }
}
