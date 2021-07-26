using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace hcloud_api.Models.Requests.Images
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateImageRequest
    {
        /// <summary>
        /// New description of Image
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Destination Image type to convert to
        /// </summary>
        [JsonProperty("type")]
        public ImageType Type { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageType
        {
            [EnumMember(Value = "snapshot")]
            Snapshot
        }

    }
}
