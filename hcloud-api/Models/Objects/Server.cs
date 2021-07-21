using hcloud_api.Models.Objects.Servers;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects
{
    public class Server
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Time window (UTC) in which the backup will run, or null if the backups are not enabled
        /// </summary>
        [JsonProperty("backup_window")]
        public string BackupWindow { get; set; }

        /// <summary>
        /// Point in time when the Resource was created
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Datacenter this Resource is located at
        /// </summary>
        [JsonProperty("datacenter")]
        public Datacenter Datacenter { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        /// <summary>
        /// Free Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("included_traffic")]
        public long? IncludedTraffic { get; set; }

        /// <summary>
        /// Inbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("ingoing_traffic")]
        public long? InboundTraffic { get; set; }

        /// <summary>
        /// ISO Image that is attached to this Server. Null if no ISO is attached.
        /// </summary>
        [JsonProperty("iso")]
        public ISO ISO { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        [JsonProperty("load_balancers")]
        public int[] LoadBalancers { get; set; }

        /// <summary>
        /// True if Server has been locked and is not available to user
        /// </summary>
        [JsonProperty("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Outbound Traffic for the current billing period in bytes
        /// </summary>
        [JsonProperty("outgoing_traffic")]
        public long? OutboundTraffic { get; set; }

        /// <summary>
        /// Size of the primary Disk
        /// </summary>
        [JsonProperty("primary_disk_size")]
        public float PrimaryDiskSize { get; set; }

        /// <summary>
        /// Private networks information
        /// </summary>
        [JsonProperty("private_net")]
        public PrivateNetwork[] PrivateNetworks { get; set; }

        /// <summary>
        /// Protection configuration for the Server
        /// </summary>
        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        /// <summary>
        /// Public network information. 
        /// The Server's IPv4 address can be found in <b>PublicNetwork->IPv4->IP</b>
        /// </summary>
        [JsonProperty("public_net")]
        public PublicNetwork PublicNetwork { get; set; }

        /// <summary>
        /// True if rescue mode is enabled. Server will then boot into rescue system on next reboot
        /// </summary>
        [JsonProperty("rescue_enabled")]
        public bool RescueEnabled { get; set; }

        /// <summary>
        /// Type of Server - determines how much ram, disk and cpu a Server has
        /// </summary>
        [JsonProperty("server_type")]
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Status of the Server
        /// </summary>
        [JsonProperty("status")]
        public ServerStatus Status { get; set; }

        /// <summary>
        /// IDs of Volumes assigned to this Server
        /// </summary>
        [JsonProperty("volumes")]
        public int[] Volumes { get; set; }
    }
}
