using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.Certificates
{
    public class CertificateStatus
    {
        /// <summary>
        /// If issuance or renewal reports <b>failed</b>, this property contains information about what happened
        /// </summary>
        [JsonProperty("error")]
        public Error Error { get; set; }

        /// <summary>
        /// Status of the issuance process of the Certificate
        /// </summary>
        [JsonProperty("issuance")]
        public IssuanceStatus Issuance { get; set; }

        /// <summary>
        /// Status of the renewal process of the Certificate.
        /// </summary>
        [JsonProperty("renewal")]
        public RenewalStatus Renewal { get; set; }
    }
}
