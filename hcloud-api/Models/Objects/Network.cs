using hcloud_api.Models.Objects.Networks;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace hcloud_api.Models.Objects
{
    public class Network
    {
        /// <summary>
        /// ID of the Network
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Network
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Point in time when the Network was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// IPv4 prefix of the whole Network
        /// </summary>
        [JsonProperty("ip_range")]
        public string IpRange { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Array of IDs of Load Balancers attached to this Network
        /// </summary>
        [JsonProperty("load_balancers")]
        public int[] LoadBalancers { get; set; }

        /// <summary>
        /// Protection configuration for the Network
        /// </summary>
        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        /// <summary>
        /// Array of routes set in this Network
        /// </summary>
        [JsonProperty("routes")]
        public Route[] Routes { get; set; }

        /// <summary>
        /// Array of IDs of Servers attached to this Network
        /// </summary>
        [JsonProperty("servers")]
        public int[] Servers { get; set; }

        /// <summary>
        /// Array subnets allocated in this Network
        /// </summary>
        [JsonProperty("subnets")]
        public Subnet[] Subnets { get; set; }
    }
}
