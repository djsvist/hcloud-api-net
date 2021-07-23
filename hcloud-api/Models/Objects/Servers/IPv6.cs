using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Servers
{
    public class IPv6
    {
        /// <summary>
        /// If the IP is blocked by our anti abuse dept
        /// </summary>
        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        /// <summary>
        /// Reverse DNS PTR entries for the IPv6 addresses of this Server, <b>null</b> by default
        /// </summary>
        [JsonProperty("dns_ptr")]
        public IPv6DNSPTR[] DNSPTRs { get; set; }

        /// <summary>
        /// IP address (v6) of this Server
        /// </summary>
        [JsonProperty("ip")]
        public string IP { get; set; }

        public class IPv6DNSPTR
        {
            /// <summary>
            /// DNS pointer for the specific IP address
            /// </summary>
            [JsonProperty("dns_ptr")]
            public string DNSPTR { get; set; }

            /// <summary>
            /// Single IPv6 address of this Server for which the reverse DNS entry has been set up
            /// </summary>
            [JsonProperty("ip")]
            public string IP { get; set; }
        }
    }
}
