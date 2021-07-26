using hcloud_api.Models.Objects.Firewalls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects
{
    public class Firewall
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Firewall rules
        /// </summary>
        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }

        [JsonProperty("applied_to")]
        public AppliedObject[] AppliedTo { get; set; }
    }
}
