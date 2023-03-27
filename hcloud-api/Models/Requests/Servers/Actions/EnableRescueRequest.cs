using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Servers.Actions
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class EnableRescueRequest
    {
        [JsonProperty("ssh_keys")]
        public IEnumerable<int> SSHKeys { get; set; }

        [JsonProperty("type")]
        public RescueType? Type { get; set; }
    }
}
