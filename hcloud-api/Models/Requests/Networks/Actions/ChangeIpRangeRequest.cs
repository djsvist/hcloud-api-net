using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Networks.Actions
{
    /// <summary>
    /// The new prefix for the whole Network
    /// </summary>
    public class ChangeIpRangeRequest
    {
        /// <summary>
        /// The new prefix for the whole Network
        /// </summary>
        [JsonProperty("ip_range")]
        [JsonRequired]
        public string IpRange { get; set; }
    }
}
