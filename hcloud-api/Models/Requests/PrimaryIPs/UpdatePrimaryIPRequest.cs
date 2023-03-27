using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.PrimaryIPs
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdatePrimaryIPRequest
    {
        /// <summary>
        /// Delete this Primary IP when the resource it is assigned to is deleted
        /// </summary>
        [JsonProperty("auto_delete")]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// New unique name to set
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
