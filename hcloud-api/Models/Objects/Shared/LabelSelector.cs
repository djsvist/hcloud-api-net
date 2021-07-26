using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class LabelSelector
    {
        /// <summary>
        /// Label selector
        /// </summary>
        [JsonProperty("selector")]
        [JsonRequired]
        public string Selector { get; set; }
    }
}
