using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Firewalls
{
    public class CreateFirewallResponse : IResponse
    {
        [JsonProperty("actions")]
        public HAction[] Actions { get; set; }

        [JsonProperty("firewall")]
        public Firewall Firewall { get; set; }
    }
}
