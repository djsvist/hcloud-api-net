using hcloud_api.Models.Objects.PrimaryIPs;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.PrimaryIPs.Actions
{
    public class AssignRequest
    {
        /// <summary>
        /// ID of the resource the Primary IP should be assigned to. Omitted if it should not be assigned.
        /// </summary>
        [JsonProperty("assignee_id")]
        public int AssigneeId { get; set; }

        /// <summary>
        /// Resource type the Primary IP can be assigned to
        /// </summary>
        [JsonProperty("assignee_type")]
        [JsonRequired]
        public AssigneeType AssigneeType { get; set; }
    }
}
