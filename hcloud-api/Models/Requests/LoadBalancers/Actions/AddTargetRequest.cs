using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Objects.LoadBalancers.Targets;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    public class AddTargetRequest
    {
        /// <summary>
        /// IP targets where the traffic should be routed through. It is only possible to use the (Public or vSwitch) IPs of Hetzner Online Root Servers belonging to the project owner.
        /// IPs belonging to other users are blocked. Additionally IPs belonging to services provided by Hetzner Cloud (Servers, Load Balancers, ...) are blocked as well.
        /// </summary>
        [JsonProperty("ip")]
        public IPInfo IP { get; set; }

        /// <summary>
        /// Configuration for type Server, required if type is <b>server</b>
        /// </summary>
        [JsonProperty("server")]
        public TargetServer Server { get; set; }

        /// <summary>
        /// Type of the resource <br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public TargetType Type { get; set; }

        /// <summary>
        /// Use the private network IP instead of the public IP of the Server, requires the Server and Load Balancer to be in the same network. Default value is false.
        /// </summary>
        [JsonProperty("use_private_ip")]
        public bool UsePrivateIp { get; set; }
    }
}
