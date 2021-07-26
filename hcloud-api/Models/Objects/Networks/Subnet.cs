using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Networks
{
    public class Subnet
    {
        /// <summary>
        /// Gateway for Servers attached to this subnet. 
        /// For subnets of type Server this is always the first IP of the network IP range.
        /// <br><b>Not used when creating a subnet</b></br>
        /// </summary>
        [JsonProperty("gateway")]
        [JsonIgnore]
        public string Gateway { get; set; }

        /// <summary>
        /// Range to allocate IPs from. Must be a Subnet of the ip_range of the parent network object and must not overlap with any other subnets or with any destinations in routes. 
        /// Minimum Network size is /30. We suggest that you pick a bigger Network with a /24 netmask.
        /// </summary>
        [JsonProperty("ip_range")]
        public string IpRange { get; set; }

        /// <summary>
        /// Name of Network zone. Currently eu-central is the only available zone.
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("network_zone")]
        [JsonRequired]
        public string NetworkZone { get; set; }

        /// <summary>
        /// Type of Subnetwork
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public SubnetType Type { get; set; }
    }
}
