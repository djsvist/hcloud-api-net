using System;
using System.Collections.Generic;
using hcloud_api.Models.Objects.Certificates;
using hcloud_api.Models.Objects.Shared;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects
{
    public class Certificate
    {
        /// <summary>
        /// ID of the Resource
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the Resource. Must be unique per Project
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Certificate and chain in PEM format, in order so that each record directly certifies the one preceding
        /// </summary>
        [JsonProperty("certificate")]
        public string Sertificate { get; set; }

        /// <summary>
        /// Point in time when the Resource was created (in ISO-8601 format)
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Domains and subdomains covered by the Certificate
        /// </summary>
        [JsonProperty("domain_names")]
        public string[] DomainNames { get; set; }

        /// <summary>
        /// SHA256 fingerprint of the Certificate
        /// </summary>
        [JsonProperty("fingerprint")]
        public string FingerPrint { get; set; }

        /// <summary>
        /// Point in time when the Certificate stops being valid (in ISO-8601 format)
        /// </summary>
        [JsonProperty("not_valid_after")]
        public DateTime? NotValidAfter { get; set; }

        /// <summary>
        /// Point in time when the Certificate becomes valid (in ISO-8601 format)
        /// </summary>
        [JsonProperty("not_valid_before")]
        public DateTime? NotValidBefore { get; set; }

        /// <summary>
        /// Current status of a type <b>managed</b> Certificate, always null for type <b>uploaded</b> Certificates
        /// </summary>
        [JsonProperty("status")]
        public CertificateStatus Status { get; set; }

        /// <summary>
        /// Type of the Certificate
        /// </summary>
        [JsonProperty("type")]
        public CertificateType Type { get; set; }

        /// <summary>
        /// Resources currently using the Certificate
        /// </summary>
        [JsonProperty("used_by")]
        public Resource[] UsedBy { get; set; }
    }
}
