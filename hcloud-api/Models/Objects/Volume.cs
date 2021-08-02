using hcloud_api.Models.Objects.Shared;
using hcloud_api.Models.Objects.Volumes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects
{
    public class Volume
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
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Filesystem of the Volume if formatted on creation, null if not formatted on creation
        /// </summary>
        [JsonProperty("format")]
        public VolumeFormat? Format { get; set; }

        /// <summary>
        /// Device path on the file system for the Volume
        /// </summary>
        [JsonProperty("linux_device")]
        public string LinuxDevice { get; set; }

        /// <summary>
        /// Location of the Volume. Volume can only be attached to Servers in the same Location.
        /// </summary>
        [JsonProperty("Location")]
        public Location Location { get; set; }

        /// <summary>
        /// Protection configuration for the Resource
        /// </summary>
        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        /// <summary>
        /// ID of the Server the Volume is attached to, null if it is not attached at all
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Size in GB of the Volume
        /// </summary>
        [JsonProperty("size")]
        public float Size { get; set; }

        /// <summary>
        /// Current status of the Volume
        /// </summary>
        [JsonProperty("status")]
        public VolumeStatus Status { get; set; }
    }
}
