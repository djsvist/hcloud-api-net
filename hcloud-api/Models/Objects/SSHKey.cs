using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class SSHKey
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        [JsonRequired]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Point in time when the Resource was created (in ISO-8601 format)
        /// </summary>
        [JsonProperty("created")]
        [JsonRequired]
        public DateTime Created { get; set; }

        /// <summary>
        /// Fingerprint of public key
        /// </summary>
        [JsonProperty("fingerprint")]
        [JsonRequired]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Public key
        /// </summary>
        [JsonProperty("public_key")]
        [JsonRequired]
        public string PublicKey { get; set; }
    }
}
