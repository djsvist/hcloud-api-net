using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AppliedObject
    {
        /// <summary>
        /// Not used when creating a firewall
        /// </summary>
        [JsonProperty("applied_to_resources")]
        [JsonIgnore]
        public AppliedResource[] AppliedResources { get; set; }

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
