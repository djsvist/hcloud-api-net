using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;

namespace hcloud_api.Models.Objects
{
    public class LoadBalancerType
    {
        /// <summary>
        /// ID of the Load Balancer type
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Unique identifier of the Load Balancer type
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the Load Balancer type
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Point in time when the Load Balancer type is deprecated
        /// </summary>
        [JsonProperty("deprecated")]
        public DateTime? Deprecated { get; set; }

        /// <summary>
        /// Number of SSL Certificates that can be assigned to a single Load Balancer
        /// </summary>
        [JsonProperty("max_assigned_certificates")]
        public int MaxAssignedCertificates { get; set; }

        /// <summary>
        /// Number of maximum simultaneous open connections
        /// </summary>
        [JsonProperty("max_connections")]
        public int MaxConnections { get; set; }

        /// <summary>
        /// Number of services a Load Balancer of this type can have
        /// </summary>
        [JsonProperty("max_services")]
        public int MaxServices { get; set; }

        /// <summary>
        /// Number of targets a single Load Balancer can have
        /// </summary>
        [JsonProperty("max_targets")]
        public int MaxTargets { get; set; }

        /// <summary>
        /// Prices in different network zones
        /// </summary>
        [JsonProperty("prices")]
        public Price[] Prices { get; set; }
    }
}
