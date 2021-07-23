using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.ISOs
{
    public class ISOsResponse : IResponse
    {
        [JsonProperty("isos")]
        public ISO[] ISOs { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
