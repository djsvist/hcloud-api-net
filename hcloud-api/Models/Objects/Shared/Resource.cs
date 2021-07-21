using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class Resource
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Type of resource referenced
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
