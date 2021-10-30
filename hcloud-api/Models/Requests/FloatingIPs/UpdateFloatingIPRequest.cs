using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.FloatingIPs
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateFloatingIPRequest
    {
        /// <summary>
        /// New floating ip name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// New Description to set
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}
