using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public class GetActionsResponse : IResponse
    {
        [JsonProperty("actions")]
        [JsonRequired]
        public HAction[] Actions { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
