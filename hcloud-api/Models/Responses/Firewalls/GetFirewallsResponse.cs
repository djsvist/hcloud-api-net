using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Firewalls
{
    public class GetFirewallsResponse : IResponse
    {
        [JsonProperty("firewalls")]
        public Firewall[] Firewalls { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
