using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers
{
    public class GetServersResponse : IResponse
    {
        [JsonProperty("servers")]
        public Server[] Servers { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
