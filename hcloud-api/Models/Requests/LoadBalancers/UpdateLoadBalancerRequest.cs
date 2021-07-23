using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.LoadBalancers
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UpdateLoadBalancerRequest
    {
        /// <summary>
        /// New Load Balancer name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }
    }
}
