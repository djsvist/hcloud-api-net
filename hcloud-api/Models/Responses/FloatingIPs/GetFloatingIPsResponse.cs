using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.FloatingIPs
{
    public class GetFloatingIPsResponse : IResponse
    {
        [JsonProperty("floating_ips")]
        [JsonRequired]
        public FloatingIP[] FloatingIPs { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
