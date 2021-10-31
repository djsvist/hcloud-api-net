using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers.Actions
{
    public class RequestConsoleResponse : ActionResponse
    {
        /// <summary>
        /// VNC password to use for this connection (this password only works in combination with a wss_url with valid token)
        /// </summary>
        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        /// <summary>
        /// URL of websocket proxy to use; this includes a token which is valid for a limited time only
        /// </summary>
        [JsonProperty("wss_url")]
        [JsonRequired]
        public string WSSUrl { get; set; }
    }
}
