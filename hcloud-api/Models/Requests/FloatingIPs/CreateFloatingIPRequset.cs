using System.Collections.Generic;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.FloatingIPs;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.FloatingIPs
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateFloatingIPRequset
    {
#pragma warning disable IDE0052 // Remove unread private members
        [JsonProperty("location")]
        private string _location;
#pragma warning restore IDE0052 // Remove unread private members

        /// <summary>
        /// Name of the IP to create
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Home Location (routing is optimized for that Location).
        /// <br /><b>Only optional if Server argument is passed.</b>
        /// </summary>
        [JsonIgnore]
        public Location Location { set => _location = value.Name; }

        /// <summary>
        /// Home Location Name (routing is optimized for that Location).
        /// <br /><b>Only optional if Server argument is passed.</b>
        /// </summary>
        [JsonIgnore]
        public string LocationName { set => _location = value; }

        /// <summary>
        /// Home Location ID (routing is optimized for that Location).
        /// <br /><b>Only optional if Server argument is passed.</b>
        /// </summary>
        [JsonIgnore]
        public int LocationId { set => _location = value.ToString(); }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Server to assign the Floating IP to
        /// <br /><b>Only optional if Location argument is passed.</b>
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Floating IP type
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public FloatingIPType Type { get; set; }
    }
}
