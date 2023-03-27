using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Servers.Actions
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ChangeProtectionRequest
    {
        [JsonProperty("delete")]
        public bool? ProtectDelete { get; set; }

        [JsonProperty("rebuild")]
        public bool? ProtectRebuild { get; set; }
    }
}
