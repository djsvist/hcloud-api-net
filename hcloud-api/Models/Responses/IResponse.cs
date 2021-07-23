using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public class IResponse
    {
        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}
