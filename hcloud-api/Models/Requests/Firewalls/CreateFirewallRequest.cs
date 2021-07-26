using hcloud_api.Models.Objects.Firewalls;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Firewalls
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateFirewallRequest
    {
        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Firewall rules
        /// </summary>
        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }

        [JsonProperty("apply_to")]
        public AppliedObject[] ApplyTo { get; set; }
    }
}
