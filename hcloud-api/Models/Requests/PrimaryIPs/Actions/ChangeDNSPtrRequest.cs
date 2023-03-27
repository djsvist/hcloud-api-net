using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.PrimaryIPs.Actions
{
    /// <summary>
    /// Select the IP address for which to change the DNS entry by passing <b>IP</b>. It can be either IPv4 or IPv6. The target hostname is set by passing <b>DNSPointer</b>.
    /// </summary>
    public class ChangeDNSPtrRequest
    {
        /// <summary>
        /// Hostname to set as a reverse DNS PTR entry
        /// </summary>
        [JsonProperty("dns_ptr")]
        public string DNSPointer { get; set; }

        /// <summary>
        /// Public IP address for which the reverse DNS entry should be set
        /// </summary>
        [JsonProperty("ip")]
        [JsonRequired]
        public string IP { get; set; }
    }
}
