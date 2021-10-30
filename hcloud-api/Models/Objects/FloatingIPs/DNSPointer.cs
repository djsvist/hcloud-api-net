using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.FloatingIPs
{
    public class DNSPointer
    {
        /// <summary>
        /// DNS pointer for the specific IP address
        /// </summary>
        [JsonProperty("dns_ptr")]
        [JsonRequired]
        public string Pointer { get; set; }

        /// <summary>
        /// Single IPv4 or IPv6 address
        /// </summary>
        [JsonProperty("ip")]
        [JsonRequired]
        public string IP { get; set; }
    }
}
