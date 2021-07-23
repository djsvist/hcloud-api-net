using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class Protection
    {
        /// <summary>
        /// If true, prevents the Resource from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }

        /// <summary>
        /// If true, prevents the Resource from being rebuilt
        /// </summary>
        [JsonProperty("rebuild")]
        public bool Rebuild { get; set; }
    }
}
