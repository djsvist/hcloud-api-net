using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Images
{
    public class GetImagesResponse : IResponse
    {
        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
