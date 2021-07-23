using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Locations
{
    public class GetLocationsResponse : IResponse
    {
        [JsonProperty("locations")]
        public Location[] Locations { get; set; }
    }
}
