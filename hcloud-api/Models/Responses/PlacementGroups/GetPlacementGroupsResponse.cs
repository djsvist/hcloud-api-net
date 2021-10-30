using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.PlacementGroups
{
    public class GetPlacementGroupsResponse : IResponse
    {
        [JsonProperty("placement_groups")]
        [JsonRequired]
        public PlacementGroup[] Groups { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
