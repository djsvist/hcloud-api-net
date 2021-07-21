using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class Location
    {
        /// <summary>
        /// ID of the Location
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the Location
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the Location
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// City the Location is closest to
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// SO 3166-1 alpha-2 code of the country the Location resides in
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Latitude of the city closest to the Location
        /// </summary>
        [JsonProperty("latitude")]
        public float Latitude { get; set; }

        /// <summary>
        /// Longitude of the city closest to the Location
        /// </summary>
        [JsonProperty("longitude")]
        public float Longitude { get; set; }

        /// <summary>
        /// Name of network zone this Location resides in
        /// </summary>
        [JsonProperty("network_zone")]
        public string NetworkZone { get; set; }
    }
}
