using hcloud_api.Models.Responses.Metas;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses
{
    public class Meta
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
