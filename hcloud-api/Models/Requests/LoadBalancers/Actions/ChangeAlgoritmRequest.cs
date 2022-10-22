using hcloud_api.Models.Objects.LoadBalancers;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeAlgoritmRequest
    {
        /// <summary>
        /// Algorithm of the Load Balancer
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public LBAlgorithmType Type { get; set; }
    }
}
