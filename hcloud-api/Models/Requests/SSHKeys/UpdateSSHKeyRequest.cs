using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.SSHKeys
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateSSHKeyRequest
    {
        /// <summary>
        /// New name Name to set
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}
