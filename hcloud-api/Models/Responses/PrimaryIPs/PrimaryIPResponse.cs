using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.PrimaryIPs
{
    /// <summary>
    /// 
    /// </summary>
    public class PrimaryIPResponse : IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("primary_ip")]
        [JsonRequired]
        public PrimaryIP PrimaryIP { get; set; }
    }
}
