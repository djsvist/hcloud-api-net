using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Volumes
{
    public class GetVolumesResponse : IResponse
    {
        [JsonProperty("volumes")]
        public Volume[] Volumes { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
