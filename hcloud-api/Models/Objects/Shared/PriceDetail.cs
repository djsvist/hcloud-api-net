using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public class PriceDetail
    {
        /// <summary>
        /// Price with VAT added
        /// </summary>
        [JsonProperty("gross")]
        public string Gross { get; set; }

        /// <summary>
        /// Price without VAT
        /// </summary>
        [JsonProperty("net")]
        public string Net { get; set; }
    }
}
