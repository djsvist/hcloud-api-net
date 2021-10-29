using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Certificates
{
    public class CertificateResponse : IResponse
    {
        [JsonProperty("certificate")]
        [JsonRequired]
        public Certificate Certificate { get; set; }
    }
}
