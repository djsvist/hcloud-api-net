using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Networks.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeProtectionRequest
    {
        /// <summary>
        /// If true, prevents the Volume from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }
    }
}
