using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Objects.LoadBalancers.Services;
using hcloud_api.Models.Objects.LoadBalancers.Targets;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects
{
    public class LoadBalancer
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Algorithm of the Load Balancer
        /// </summary>
        [JsonProperty("algorithm")]
        public LBAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Free Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("included_traffic")]
        public long IncludedTraffic { get; set; }

        /// <summary>
        /// Inbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("ingoing_traffic")]
        public long? InboundTraffic { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("load_balancer_type")]
        public LoadBalancerType LoadBalancerType { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Outbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("outgoing_traffic")]
        public int? OutboundTraffic { get; set; }

        /// <summary>
        /// Private networks information
        /// </summary>
        [JsonProperty("private_net")]
        public PrivateNetwork[] PrivateNetworks { get; set; }

        /// <summary>
        /// Protection configuration for the Resource
        /// </summary>
        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        /// <summary>
        /// Public network information
        /// </summary>
        [JsonProperty("public_net")]
        public PublicNetwork PublicNetwork { get; set; }

        /// <summary>
        /// Array of services
        /// </summary>
        [JsonProperty("services")]
        public LoadBalancerService[] Services { get; set; }

        /// <summary>
        /// List of targets that belong to this Load Balancer
        /// </summary>
        [JsonProperty("targets")]
        public LoadBalancerTarget[] Targets { get; set; }
    }
}
