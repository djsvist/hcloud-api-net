using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Servers
{
    public class Firewall
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Status of the Firewall on the Server
        /// </summary>
        [JsonProperty("status")]
        public FirewallStatus Status { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum FirewallStatus
        {
            Applied,
            Pending
        }
    }
}
