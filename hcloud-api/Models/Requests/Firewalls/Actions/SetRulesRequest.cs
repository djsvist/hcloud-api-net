using hcloud_api.Models.Objects.Firewalls;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Firewalls.Actions
{
    public class SetRulesRequest
    {
        /// <summary>
        /// Array of rules
        /// </summary>
        [JsonProperty("rules")]
        [JsonRequired]
        public IEnumerable<Rule> Rules { get; set; }
    }
}
