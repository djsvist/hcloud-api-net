using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.PlacementGroups
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdatePlacementGroupRequest
    {
        /// <summary>
        /// New Placement group name
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
