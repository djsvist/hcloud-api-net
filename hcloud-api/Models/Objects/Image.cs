using hcloud_api.Models.Objects.Images;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace hcloud_api.Models.Objects
{
    public class Image
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the Image. This value is only set for system Images.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the Image
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// ID of Server the Image is bound to. Only set for Images of type <b>backup</b>
        /// </summary>
        [JsonProperty("bound_to")]
        public int? BoundTo { get; set; }

        /// <summary>
        /// Build ID of the Image
        /// </summary>
        [JsonProperty("build_id")]
        public string BuildId { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("created_from")]
        public CreatedFrom CreatedFrom { get; set; }

        /// <summary>
        /// Point in time where the Image was deleted
        /// </summary>
        [JsonProperty("deleted")]
        public DateTime? Deleted { get; set; }

        /// <summary>
        /// Point in time where the Image was deleted
        /// </summary>
        [JsonProperty("deprecated")]
        public DateTime? Deprecated { get; set; }

        /// <summary>
        /// Size of the disk contained in the Image in GB
        /// </summary>
        [JsonProperty("disk_size")]
        public float DiskSize { get; set; }

        /// <summary>
        /// Size of the Image file in our storage in GB.
        /// For snapshot Images this is the value relevant for calculating costs for the Image.
        /// </summary>
        [JsonProperty("image_size")]
        public float ImageSize { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Flavor of operating system contained in the Image
        /// </summary>
        [JsonProperty("os_flavor")]
        public OsFlavor OsFlavor { get; set; }

        /// <summary>
        /// Operating system version
        /// </summary>
        [JsonProperty("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Protection configuration for the Resource
        /// </summary>
        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        /// <summary>
        /// Indicates that rapid deploy of the Image is available
        /// </summary>
        [JsonProperty("rapid_deploy")]
        public bool RapidDeploy { get; set; }

        /// <summary>
        /// Whether the Image can be used or if it's still being created or unavailable
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }

        /// <summary>
        /// Type of the Image
        /// </summary>
        [JsonProperty("type")]
        public ImageType Type { get; set; }
    }
}
