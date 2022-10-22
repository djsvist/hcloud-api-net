using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.PrimaryIPs
{
    /// <summary>
    /// 
    /// </summary>
    public class GetPrimaryIPsResponse : IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("primary_ips")]
        [JsonRequired]
        public PrimaryIP[] PrimaryIPs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
