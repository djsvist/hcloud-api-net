using System;
using System.Collections.Generic;
using hcloud_api.Models.Objects.PlacementGroups;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class PlacementGroup
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        [JsonRequired]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Point in time when the Resource was created (in ISO-8601 format)
        /// </summary>
        [JsonProperty("created")]
        [JsonRequired]
        public DateTime Created { get; set; }

        /// <summary>
        /// Array of IDs of Servers that are part of this Placement Group
        /// </summary>
        [JsonProperty("servers")]
        [JsonRequired]
        public int[] Servers { get; set; }

        /// <summary>
        /// Type of the Placement Group
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public PlacementGroupType Type { get; set; }
    }
}
