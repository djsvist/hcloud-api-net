using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Volumes.Actions
{
    public class ResizeRequest
    {
        /// <summary>
        /// New Volume size in GB (must be greater than current size)
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
    }
}
