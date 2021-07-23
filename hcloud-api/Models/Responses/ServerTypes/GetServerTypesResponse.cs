using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.ServerTypes
{
    public class GetServerTypesResponse : IResponse
    {
        [JsonProperty("server_types")]
        public ServerType[] ServerTypes { get; set; }
    }
}
