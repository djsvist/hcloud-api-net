using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.SSHKeys
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateSSHKeyRequest
    {
        /// <summary>
        /// Name of the SSH key
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Public key
        /// <br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("public_key")]
        [JsonRequired]
        public string PublicKey { get; set; }
    }
}
