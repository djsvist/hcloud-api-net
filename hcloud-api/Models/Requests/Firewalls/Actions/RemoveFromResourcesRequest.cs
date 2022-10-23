using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Firewalls.Actions
{
    public class RemoveFromResourcesRequest
    {
        /// <summary>
        /// Resources the Firewall should be removed from
        /// </summary>
        [JsonProperty("remove_from")]
        [JsonRequired]
        public IEnumerable<FirewallResourceSelector> RemoveFrom { get; set; }
    }
}
