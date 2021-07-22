using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects.LoadBalancers.HealthChecks
{
    public class HealthCheckHttpCfg
    {
        /// <summary>
        /// Host header to send in the HTTP request. 
        /// May not contain spaces, percent or backslash symbols.
        /// Can be null, in that case no host header is sent.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Include)]
        public string Domain { get; set; }

        /// <summary>
        /// HTTP path to use for health checks
        /// </summary>
        [JsonProperty("path")]
        [JsonRequired]
        public string Path { get; set; }

        /// <summary>
        /// String that must be contained in HTTP response in order to pass the health check
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response { get; set; }

        /// <summary>
        /// List of returned HTTP status codes in order to pass the health check.
        /// Supports the wildcards <b>?</b> for exactly one character and <b>*</b> for multiple ones. 
        /// The default is to pass the health check for any status code between 2?? and 3??.
        /// </summary>
        [JsonProperty("status_codes", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> StatusCodes { get; set; }

        /// <summary>
        /// Use HTTPS for health check
        /// </summary>
        [JsonProperty("tls")]
        public bool TLS { get; set; }
    }
}
