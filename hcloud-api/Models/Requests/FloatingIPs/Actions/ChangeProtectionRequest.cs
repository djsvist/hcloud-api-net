using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.FloatingIPs.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeProtectionRequest
    {
        /// <summary>
        /// If true, prevents the Floating IP from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }
    }
}
