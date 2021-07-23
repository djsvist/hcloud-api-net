using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    public class IPInfo
    {
        /// <summary>
        /// IP address of this Server
        /// </summary>
        [JsonProperty("ip")]
        public string IP { get; set; }
    }
}
