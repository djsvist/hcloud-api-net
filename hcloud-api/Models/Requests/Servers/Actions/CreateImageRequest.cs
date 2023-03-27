using System.Collections.Generic;
using hcloud_api.Models.Objects.Images;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Servers.Actions
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateImageRequest
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("type")]
        public ImageType? Type { get; set; }
    }
}
