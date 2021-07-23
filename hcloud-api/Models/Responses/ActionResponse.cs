using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public class ActionResponse : IResponse
    {
        [JsonProperty("action")]
        public HAction Action { get; set; }
    }
}
