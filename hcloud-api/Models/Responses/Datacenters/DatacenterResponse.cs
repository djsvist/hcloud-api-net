using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Datacenters
{
    public class DatacenterResponse : IResponse
    {
        [JsonProperty("datacenter")]
        public Datacenter Datacenter { get; set; }
    }
}
