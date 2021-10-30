using System.Collections.Generic;
using hcloud_api.Models.Objects.PlacementGroups;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.PlacementGroups
{
    public class CreatePlacementGroupRequest
    {
        /// <summary>
        /// Name of the PlacementGroup
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Define the Placement Group Type.
        /// <br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public PlacementGroupType Type { get; set; }
    }
}
