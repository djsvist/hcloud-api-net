using hcloud_api.Models.Objects.Datacenters;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class Datacenter
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the Datacenter
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Description of the Datacenter
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// The Server types the Datacenter can handle
        /// </summary>
        [JsonProperty("server_types")]
        public DcServerTypes ServerTypes { get; set; }
    }
}
