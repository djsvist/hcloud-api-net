using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.PrimaryIPs.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeProtectionRequest
    {
        /// <summary>
        /// If true, prevents the Primary IP from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }
    }
}
