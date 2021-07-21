using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public abstract class IResponse
    {
        [JsonProperty("next_actions")]
        public Error Error { get; set; }
    }
}
