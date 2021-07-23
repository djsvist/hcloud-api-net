using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers.Targets
{
    public class TargetServer
    {
        [JsonProperty("id")]
        [JsonRequired]
        public int Id { get; set; }
    }
}
