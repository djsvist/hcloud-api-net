using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Datacenters
{
    public class DatacentersResponse : IResponse
    {
        [JsonProperty("datacenters")]
        public Datacenter[] Datacenters { get; set; }

        /// <summary>
        /// The Datacenter which is recommended to be used to create new Servers.
        /// </summary>
        [JsonProperty("recommendation")]
        public int Recommendation { get; set; }
    }
}
