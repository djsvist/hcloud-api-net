using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class Price
    {
        /// <summary>
        /// Name of the Location the price is for
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Hourly costs for a Server type in this Location
        /// </summary>
        [JsonProperty("price_hourly")]
        public PriceDetail Hourly { get; set; }

        /// <summary>
        /// Monthly costs for a Server type in this Location
        /// </summary>
        [JsonProperty("price_monthly")]
        public PriceDetail Monthly { get; set; }

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
}
