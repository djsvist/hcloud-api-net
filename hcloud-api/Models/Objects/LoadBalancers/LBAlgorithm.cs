using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    public class LBAlgorithm
    {
        /// <summary>
        /// Type of the algorithm
        /// </summary>
        [JsonProperty("type")]
        public LBAlgorithmType Type { get; set; }
    }
}
