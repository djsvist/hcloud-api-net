using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers
{
    public class ServerResponse : IResponse
    {
        [JsonProperty("server")]
        public Server Server { get; set; }
    }
}
