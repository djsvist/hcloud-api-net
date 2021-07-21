using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers
{
    public class CreateServerResponse : NextActionsResponse
    {
        /// <summary>
        /// Root password when no SSH keys have been specified
        /// </summary>
        [JsonProperty("root_password")]
        public string RootPassword { get; set; }

        [JsonProperty("server")]
        public Server Server { get; set; }
    }
}
