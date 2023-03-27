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
    }
}
