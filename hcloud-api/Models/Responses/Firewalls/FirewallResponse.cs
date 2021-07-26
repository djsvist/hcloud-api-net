using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Firewalls
{
    public class FirewallResponse : IResponse
    {
        [JsonProperty("firewall")]
        public Firewall Firewall { get; set; }
    }
}
