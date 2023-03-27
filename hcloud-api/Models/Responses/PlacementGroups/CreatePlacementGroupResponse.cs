using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.PlacementGroups
{
    public class CreatePlacementGroupResponse : ActionResponse
    {
        [JsonProperty("placement_group")]
        [JsonRequired]
        public PlacementGroup Group { get; set; }
    }
}
