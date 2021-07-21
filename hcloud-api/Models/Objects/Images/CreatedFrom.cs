using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Images
{
    public class CreatedFrom
    {
        /// <summary>
        /// ID of the Server the Image was created from
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Server name at the time the Image was created
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
