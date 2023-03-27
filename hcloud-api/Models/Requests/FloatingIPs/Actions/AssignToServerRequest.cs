using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.FloatingIPs.Actions
{
    public class AssignToServerRequest
    {
        /// <summary>
        /// ID of the Server the Floating IP shall be assigned to
        /// </summary>
        [JsonProperty("server")]
        [JsonRequired]
        public int ServerId { get; set; }
    }
}
