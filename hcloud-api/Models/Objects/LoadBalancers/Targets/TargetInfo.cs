using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    public class TargetInfo
    {
        [JsonProperty("health_status")]
        public IList<TargetHealthStatus> HealthStatuses { get; set; }

        [JsonProperty("server")]
        public TargetServer Server { get; set; }

        [JsonProperty("type")]
        public TargetType Type { get; set; }

        [JsonProperty("use_private_ip")]
        public bool UsePrivateIp { get; set; }
    }
}
