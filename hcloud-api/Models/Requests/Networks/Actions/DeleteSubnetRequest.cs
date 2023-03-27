using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Networks.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSubnetRequest
    {
        /// <summary>
        /// IP range of subnet to delete
        /// </summary>
        [JsonProperty("ip_range")]
        [JsonRequired]
        public string IpRange { get; set; }
    }
}
