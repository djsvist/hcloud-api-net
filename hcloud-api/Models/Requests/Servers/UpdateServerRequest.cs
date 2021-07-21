using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Servers
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateServerRequest
    {
        /// <summary>
        /// New name to set
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}
