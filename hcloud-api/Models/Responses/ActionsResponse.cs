using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public class ActionsResponse : IResponse
    {
        [JsonProperty("actions")]
        [JsonRequired]
        public HAction[] Actions { get; set; }
    }
}
