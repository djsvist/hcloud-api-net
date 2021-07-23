using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;
using System;

namespace hcloud_api.Models.Objects
{
    public class HAction
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Command executed in the Action
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// Error message for the Action if error occurred, otherwise null
        /// </summary>
        [JsonProperty("error")]
        public Error Error { get; set; }

        /// <summary>
        /// Point in time when the Action was finished.
        /// Only set if the Action is finished otherwise null.
        /// </summary>
        [JsonProperty("finished")]
        public DateTime? Finished { get; set; }

        /// <summary>
        /// Progress of Action in percent
        /// </summary>
        [JsonProperty("progress")]
        public float Progress { get; set; }

        /// <summary>
        /// Resources the Action relates to
        /// </summary>
        [JsonProperty("resources")]
        public Resource[] Resources { get; set; }

        /// <summary>
        /// Point in time when the Action was finished.
        /// Only set if the Action is finished otherwise null.
        /// </summary>
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <summary>
        /// Status of the Action
        /// </summary>
        [JsonProperty("status")]
        public ActionStatus Status { get; set; }
    }
}
