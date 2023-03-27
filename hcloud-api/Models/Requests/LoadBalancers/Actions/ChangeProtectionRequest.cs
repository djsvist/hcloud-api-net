using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeProtectionRequest
    {
        /// <summary>
        /// If true, prevents the Load Balancer from being deleted
        /// </summary>
        [JsonProperty("delete")]
        public bool Delete { get; set; }
    }
}
