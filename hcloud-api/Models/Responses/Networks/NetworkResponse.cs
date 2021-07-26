using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Networks
{
    public class NetworkResponse : IResponse
    {
        [JsonProperty("network")]
        public Network Network { get; set; }
    }
}
