using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachToNetworkRequest
    {
        /// <summary>
        /// IP to request to be assigned to this Load Balancer; if you do not provide this then you will be auto assigned an IP address
        /// </summary>
        [JsonProperty("ip")]
        public string IP { get; set; }

        /// <summary>
        /// ID of an existing network to attach the Load Balancer to
        /// </summary>
        [JsonProperty("network")]
        [JsonRequired]
        public int Network { get; set; }
    }
}
