using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.ISOs
{
    public class ISOResponse : IResponse
    {
        [JsonProperty("iso")]
        public ISO ISO { get; set; }
    }
}
