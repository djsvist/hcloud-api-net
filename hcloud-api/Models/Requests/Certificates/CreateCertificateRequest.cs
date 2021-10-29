using System.Collections.Generic;
using hcloud_api.Models.Objects.Certificates;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Certificates
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateCertificateRequest
    {
        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Certificate and chain in PEM format, in order so that each record directly certifies the one preceding.
        /// <br/>
        /// Required for type <b>uploaded</b> Certificates.
        /// </summary>
        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Domains and subdomains that should be contained in the Certificate issued by Let's Encrypt.
        /// <br/>
        /// Required for type <b>managed</b> Certificates.
        /// </summary>
        [JsonProperty("domain_names")]
        public IEnumerable<string> DomainNames { get; set; }

        /// <summary>
        /// Certificate key in PEM format.
        /// <br/>
        /// Required for type <b>uploaded</b> Certificates.
        /// </summary>
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Choose between uploading a Certificate in PEM format or requesting a managed Let's Encrypt Certificate.
        /// <br/>
        /// If omitted defaults to <b>uploaded</b>
        /// </summary>
        [JsonProperty("type")]
        public CertificateType? Type { get; set; }
    }
}
