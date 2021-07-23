using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    public class TargetHealthStatus
    {
        [JsonProperty("listen_port")]
        public int ListenPort { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
