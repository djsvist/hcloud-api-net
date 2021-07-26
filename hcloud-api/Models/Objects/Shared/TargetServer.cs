using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Shared
{
    public class TargetServer
    {
        [JsonProperty("id")]
        [JsonRequired]
        public int Id { get; set; }
    }
}
