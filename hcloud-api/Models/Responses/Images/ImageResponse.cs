using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Images
{
    public class ImageResponse : IResponse
    {
        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}
