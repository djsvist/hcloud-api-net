using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Datacenters
{
    public class DcServerTypes
    {
        /// <summary>
        /// IDs of Server types that are supported and for which the Datacenter has enough resources left
        /// </summary>
        [JsonProperty("available")]
        public int[] Available { get; set; }

        /// <summary>
        /// IDs of Server types that are supported and for which the Datacenter has enough resources left
        /// </summary>
        [JsonProperty("available_for_migration")]
        public int[] AvailableForMigration { get; set; }

        /// <summary>
        /// IDs of Server types that are supported in the Datacenter
        /// </summary>
        [JsonProperty("supported")]
        public int[] Supported { get; set; }
    }
}
