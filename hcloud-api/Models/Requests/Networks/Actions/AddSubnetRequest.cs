using hcloud_api.Models.Objects.Networks;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Networks.Actions
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AddSubnetRequest
    {
        /// <summary>
        /// Range to allocate IPs from. Must be a Subnet of the ip_range of the parent network object and must not overlap with any other subnets or with any destinations in routes.
        /// If the Subnet is of type vSwitch, it also can not overlap with any gateway in routes.
        /// Minimum Network size is /30. We suggest that you pick a bigger Network with a /24 netmask.
        /// </summary>
        [JsonProperty("ip_range")]
        public string IpRange { get; set; }

        /// <summary>
        /// Name of Network zone. The Location object contains the <b>network_zone</b> property each Location belongs to.
        /// </summary>
        [JsonProperty("network_zone")]
        [JsonRequired]
        public string NetworkZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public SubnetType Type { get; set; }

        /// <summary>
        /// ID of the robot vSwitch. Must be supplied if the subnet is of type vswitch.
        /// </summary>
        [JsonProperty("vswitch_id")]
        public int? VSwitchId { get; set; }
    }
}
