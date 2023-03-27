using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Certificates
{
    public class GetCertificatesResponse : IResponse
    {
        [JsonProperty("certificate")]
        public Certificate[] Certificates { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
