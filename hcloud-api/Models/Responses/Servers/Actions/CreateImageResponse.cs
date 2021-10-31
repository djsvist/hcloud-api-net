using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers.Actions
{
    public class CreateImageResponse : ActionResponse
    {
        [JsonProperty("image")]
        public Image Image { get; set; }
    }
}
