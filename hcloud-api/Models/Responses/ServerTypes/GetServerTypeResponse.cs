using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.ServerTypes
{
    public class GetServerTypeResponse : IResponse
    {
        [JsonProperty("server_type")]
        public ServerType ServerType { get; set; }
    }
}
