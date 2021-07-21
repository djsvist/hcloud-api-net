using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class Error
    {
        /// <summary>
        /// Fixed machine readable code
        /// </summary>
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        /// <summary>
        /// Humanized error message
        /// </summary>
        [JsonProperty("message", Required = Required.Always)]
        public string Message { get; set; }
    }
}
