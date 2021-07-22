using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class LoadBalancerTarget
    {
        /// <summary>
        /// List of health statuses of the services on this target
        /// </summary>
        [JsonProperty("health_status")]
        public IList<TargetHealthStatus> HealthStatuses { get; set; }

        /// <summary>
        /// IP targets where the traffic should be routed through.
        /// It is only possible to use the (Public or vSwitch) IPs of Hetzner Online Root Servers belonging to the project owner. 
        /// IPs belonging to other users are blocked. 
        /// Additionally IPs belonging to services provided by Hetzner Cloud (Servers, Load Balancers, ...) are blocked as well.
        /// </summary>
        [JsonProperty("ip")]
        public IPInfo IP { get; set; }

        /// <summary>
        /// Label selector and a list of selected targets
        /// </summary>
        [JsonProperty("label_selector")]
        public LabelSelector LabelSelector { get; set; }

        /// <summary>
        /// Server where the traffic should be routed through
        /// </summary>
        [JsonProperty("server")]
        public TargetServer Server { get; set; }

        /// <summary>
        /// List of selected targets
        /// </summary>
        [JsonProperty("targets")]
        public IList<TargetInfo> Targets { get; set; }

        /// <summary>
        /// Type of the resource
        /// </summary>
        [JsonProperty("type")]
        public TargetType Type { get; set; }

        /// <summary>
        /// Use the private network IP instead of the public IP. Default value is false.
        /// </summary>
        [JsonProperty("use_private_ip")]
        public bool UsePrivateIp { get; set; }
    }
}
