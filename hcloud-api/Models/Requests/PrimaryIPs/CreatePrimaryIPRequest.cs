using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.PrimaryIPs;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.PrimaryIPs
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreatePrimaryIPRequest
    {
#pragma warning disable IDE0052
        [JsonProperty("datacenter")]
        private string datacenter;
#pragma warning restore IDE0052

        /// <summary>
        /// ID of the resource the Primary IP should be assigned to. Omitted if it should not be assigned.
        /// </summary>
        [JsonProperty("assignee_id")]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// Resource type the Primary IP can be assigned to
        /// </summary>
        [JsonProperty("assignee_type")]
        [JsonRequired]
        public AssigneeType? AssigneeType { get; set; }

        /// <summary>
        /// Delete the Primary IP when the Server it is assigned to is deleted.
        /// </summary>
        [JsonProperty("auto_delete")]
        public bool AutoDelete { get; set; }

        /// <summary>
        /// Datacenter the Primary IP will be bound to. Needs to be omitted if <see cref="AssigneeId"/> is passed.
        /// </summary>
        [JsonIgnore]
        public Datacenter Datacenter
        {
            set => datacenter = value.Id.ToString();
        }

        /// <summary>
        /// Name of Datacenter the Primary IP will be bound to. Needs to be omitted if <see cref="AssigneeId"/> is passed.
        /// </summary>
        [JsonIgnore]
        public string DatacenterName
        {
            set => datacenter = value;
        }

        /// <summary>
        /// ID of Datacenter the Primary IP will be bound to. Needs to be omitted if <see cref="AssigneeId"/> is passed.
        /// </summary>
        [JsonIgnore]
        public int DatacenterId
        {
            set => datacenter = value.ToString();
        }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name of the IP to create
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// Primary IP type
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public IPType Type { get; set; }
    }
}
