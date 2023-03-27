using hcloud_api.Models.Objects.PrimaryIPs;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects
{
    public class PrimaryIP
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
        /// ID of the resource the Primary IP is assigned to, null if it is not assigned at all
        /// </summary>
        [JsonProperty("assignee_id")]
        [JsonRequired]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// Resource type the Primary IP can be assigned to
        /// </summary>
        [JsonProperty("assignee_type")]
        [JsonRequired]
        public AssigneeType AssigneeType { get; set; }

        /// <summary>
        /// Delete this Primary IP when the resource it is assigned to is deleted
        /// </summary>
        [JsonProperty("auto_delete")]
        [JsonRequired]
        public bool AutoDelete { get; set; }

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
        /// Datacenter this Primary IP is located at
        /// </summary>
        [JsonProperty("datacenter")]
        [JsonRequired]
        public Datacenter Datacenter { get; set; }

        /// <summary>
        /// Array of reverse DNS entries
        /// </summary>
        [JsonProperty("dns_ptr")]
        [JsonRequired]
        public DNSPointer[] DNSPointers { get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty("ip")]
        [JsonRequired]
        public string IP { get; set; }

        /// <summary>
        /// Protection configuration for the Resource
        /// </summary>
        [JsonProperty("protection")]
        [JsonRequired]
        public Protection Protection { get; set; }

        /// <summary>
        /// Type of the Primary IP
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public IPType Type { get; set; }
    }
}
