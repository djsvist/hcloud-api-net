using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Objects.LoadBalancers.Targets;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class RemoveTargetRequest
    {
        /// <summary>
        /// IP targets where the traffic should be routed through.
        /// It is only possible to use the (Public or vSwitch) IPs of Hetzner Online Root Servers belonging to the project owner.
        /// IPs belonging to other users are blocked.
        /// Additionally IPs belonging to services provided by Hetzner Cloud (Servers, Load Balancers, ...) are blocked as well.
        /// </summary>
        [JsonProperty("ip")]
        public IPInfo IP { get; set; }

        /// <summary>
        /// Configuration for label selector targets, required if type is <b><see cref="TargetType.Label_selector"/></b>
        /// </summary>
        public Dictionary<string, string> LabelSelectors { get; set; }

        /// <summary>
        /// Configuration for type Server, required if type is <b><see cref="TargetType.Server"/></b>
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
    }
}
