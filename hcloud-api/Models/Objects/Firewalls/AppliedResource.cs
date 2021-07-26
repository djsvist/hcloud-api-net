using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Firewalls
{
    public class AppliedResource
    {
        [JsonProperty("server")]
        public TargetServer Server { get; set; }

        [JsonProperty("type")]
        [JsonRequired]
        public AppliedResourceType Type { get; set; }
    }
}
