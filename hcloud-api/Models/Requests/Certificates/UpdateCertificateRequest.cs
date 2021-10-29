using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Certificates
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateCertificateRequest
    {
        /// <summary>
        /// New certificate name
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
