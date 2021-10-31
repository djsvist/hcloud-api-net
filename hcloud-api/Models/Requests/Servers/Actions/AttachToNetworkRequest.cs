using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Servers.Actions
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AttachToNetworkRequest
    {
        [JsonProperty("alias_ips")]
        public IEnumerable<string> AliasIPs { get; set; }

        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("network")]
        [JsonRequired]
        public int Network { get; set; }
    }
}
