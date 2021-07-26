using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Networks
{
    public class GetNetworksResponse : IResponse
    {
        [JsonProperty("networks")]
        public Network[] Networks { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
