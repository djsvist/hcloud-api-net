using hcloud_api.Models.Objects.ISOs;
using Newtonsoft.Json;
using System;

namespace hcloud_api.Models.Objects
{
    public class ISO
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the ISO. Only set for public ISOs
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the ISO
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Timestamp of deprecation, null if ISO is still available.
        /// After the deprecation time it will no longer be possible to attach the ISO to Servers.
        /// </summary>
        [JsonProperty("deprecated")]
        public DateTime? Deprecated { get; set; }

        /// <summary>
        /// Type of the ISO
        /// </summary>
        [JsonProperty("type")]
        public ISOType Type { get; set; }
    }
}
