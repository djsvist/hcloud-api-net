using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Servers
{
    public class PrivateNetwork
    {
        [JsonProperty("alias_ips")]
        public string[] AliasIPs { get; set; }

        [JsonProperty("ip")]
        public string IP { get; set; }

        [JsonProperty("mac_address")]
        public string MacAddress { get; set; }

        [JsonProperty("network")]
        public int Network { get; set; }
    }
}
