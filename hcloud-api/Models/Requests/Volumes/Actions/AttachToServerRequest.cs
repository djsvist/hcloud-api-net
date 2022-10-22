using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Volumes.Actions
{
    public class AttachToServerRequest
    {
        /// <summary>
        /// ID of the Server the Volume will be attached to
        /// </summary>
        [JsonProperty("server")]
        public int Server { get; set; }

        /// <summary>
        /// Auto-mount the Volume after attaching it
        /// </summary>
        [JsonProperty("automount")]
        public bool Automount { get; set; }
    }
}
