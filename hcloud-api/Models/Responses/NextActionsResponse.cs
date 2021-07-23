using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public abstract class NextActionsResponse : ActionResponse
    {
        [JsonProperty("next_actions")]
        public HAction[] NextActions { get; set; }
    }
}
