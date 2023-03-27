using hcloud_api.Models.Objects.Firewalls;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Firewalls
{
    /// <summary>
    /// Resources the Firewall should be applied to
    /// </summary>
    public class FirewallResourceSelector
    {
        /// <summary>
        /// Configuration for type LabelSelector, required if type is <b>label_selector</b>
        /// </summary>
        [JsonProperty("label_selector")]
        public LabelSelector LabelSelector { get; set; }

        /// <summary>
        /// Configuration for type Server, required if type is <b>server</b>
        /// </summary>
        [JsonProperty("server")]
        public TargetServer Server { get; set; }

        /// <summary>
        /// Type of resource referenced
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public AppliedObjectType Type { get; set; }
    }
}
