using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class DetachFromNetworkRequest
    {
        /// <summary>
        /// ID of an existing network to attach the Load Balancer to
        /// </summary>
        [JsonProperty("network")]
        [JsonRequired]
        public int NetworkId { get; set; }

        /// <summary>
        /// Existing network to attach the Load Balancer to
        /// </summary>
        [JsonIgnore]
        public Network Network
        {
            set => NetworkId = value.Id;
        }
    }
}
