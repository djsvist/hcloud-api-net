using hcloud_api.Models.Objects.ServerTypes;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class ServerType
    {
        /// <summary>
        /// ID of the Server type
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the Server type
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the Server type
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Number of cpu cores a Server of this type will have
        /// </summary>
        [JsonProperty("cores")]
        public int Cores { get; set; }

        /// <summary>
        /// Type of cpu
        /// </summary>
        [JsonProperty("cpu_type")]
        public CpuType CpuType { get; set; }

        /// <summary>
        /// True if Server type is deprecated
        /// </summary>
        [JsonProperty("deprecated")]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Disk size a Server of this type will have in GB
        /// </summary>
        [JsonProperty("disk")]
        public float Disk { get; set; }

        /// <summary>
        /// Memory a Server of this type will have in GB
        /// </summary>
        [JsonProperty("memory")]
        public float Memory { get; set; }

        /// <summary>
        /// Prices in different Locations
        /// </summary>
        [JsonProperty("prices")]
        public Price[] Prices { get; set; }

        /// <summary>
        /// Type of Server boot drive. Local has higher speed. Network has better availability.
        /// </summary>
        [JsonProperty("storage_type")]
        public StorageType StorageType { get; set; }
    }
}
