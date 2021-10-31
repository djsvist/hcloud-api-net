using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers.Actions
{
    public class RebuildServerResponse : ActionResponse
    {
        /// <summary>
        /// Root password when no SSH keys have been specified
        /// </summary>
        [JsonProperty("root_password")]
        public string RootPassword { get; set; }
    }
}
