using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class TargetServer
    {
        /// <summary>
        /// ID of the Server
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
        public int Id { get; set; }
    }
}
