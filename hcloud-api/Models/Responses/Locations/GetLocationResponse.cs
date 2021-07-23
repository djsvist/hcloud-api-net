using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Locations
{
    public class GetLocationResponse : IResponse
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}
