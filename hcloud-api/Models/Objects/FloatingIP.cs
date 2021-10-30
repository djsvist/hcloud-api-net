using System;
using System.Collections.Generic;
using hcloud_api.Models.Objects.FloatingIPs;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class FloatingIP
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
        /// Whether the IP is blocked
        /// </summary>
        [JsonProperty("blocked")]
        [JsonRequired]
        public bool Blocked { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        [JsonRequired]
        public DateTime Created { get; set; }

        /// <summary>
        /// Description of the Resource
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Array of reverse DNS entries
        /// </summary>
        [JsonProperty("dns_ptr")]
        [JsonRequired]
        public DNSPointer[] DNSPointers { get; set; }

        /// <summary>
        /// Location the Floating IP was created in. Routing is optimized for this Location.
        /// </summary>
        [JsonProperty("home_location")]
        [JsonRequired]
        public Location Location { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty("ip")]
        [JsonRequired]
        public string IP { get; set; }

        /// <summary>
        /// Protection configuration for the Server
        /// </summary>
        [JsonProperty("protection")]
        [JsonRequired]
        public Protection Protection { get; set; }

        /// <summary>
        /// ID of the Server the Floating IP is assigned to, null if it is not assigned at all
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Type of the Floating IP
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public FloatingIPType Type { get; set; }
    }
}
