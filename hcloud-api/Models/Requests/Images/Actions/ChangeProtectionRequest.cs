using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Images.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeProtectionRequest
    {
        /// <summary>
        /// If true, prevents the snapshot from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }
    }
}
