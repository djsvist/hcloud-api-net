using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers.Actions
{
    public class EnableRescueResponse : ActionResponse
    {
        [JsonProperty("root_password")]
        public string RootPassword { get; set; }
    }
}
