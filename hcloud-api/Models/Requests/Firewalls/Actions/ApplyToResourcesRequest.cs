using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Firewalls.Actions
{
    public class ApplyToResourcesRequest
    {
        /// <summary>
        /// Resources the Firewall should be applied to
        /// </summary>
        [JsonProperty("apply_to")]
        public IEnumerable<FirewallResourceSelector> ApplyTo { get; set; }
    }
}
