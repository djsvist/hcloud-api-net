using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Certificates
{
    public class CreateCertificateResponse : ActionResponse
    {
        [JsonProperty("certificate")]
        public Certificate Certificate { get; set; }
    }
}
