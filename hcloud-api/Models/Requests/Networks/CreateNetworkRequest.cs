using hcloud_api.Models.Objects.Networks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.Networks
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateNetworkRequest
    {
        /// <summary>
        /// Name of the Network
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// IP range of the whole network which must span all included subnets. 
        /// Must be one of the private IPv4 ranges of RFC1918. Minimum network size is /24. 
        /// We highly recommend that you pick a larger network with a /16 netmask.
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("ip_range")]
        [JsonRequired]
        public string IpRange { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Array of routes set in this network. 
        /// The destination of the route must be one of the private IPv4 ranges of RFC1918. 
        /// The gateway must be a subnet/IP of the ip_range of the network object.
        /// The destination must not overlap with an existing ip_range in any subnets or with any destinations in other routes or with the first IP of the networks ip_range or with 172.31.1.1. 
        /// The gateway cannot be the first IP of the networks ip_range and also cannot be 172.31.1.1.
        /// </summary>
        [JsonProperty("routes")]
        public Route[] Routes { get; set; }

        /// <summary>
        /// Array subnets allocated in this Network
        /// </summary>
        [JsonProperty("subnets")]
        public Subnet[] Subnets { get; set; }
    }
}
