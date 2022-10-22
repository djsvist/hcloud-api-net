using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects.LoadBalancers.Services
{
    /// <summary>
    /// Configuration option for protocols http and https
    /// </summary>
    public class HttpCfg
    {
        /// <summary>
        /// IDs of the Certificates to use for TLS/SSL termination by the Load Balancer; empty for TLS/SSL passthrough or if <b>protocol</b> is "http"
        /// </summary>
        [JsonProperty("certificates", NullValueHandling = NullValueHandling.Ignore)]
        public IList<int> Certificates { get; set; }

        /// <summary>
        /// Lifetime of the cookie used for sticky sessions
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("cookie_lifetime")]
        [JsonRequired]
        public int CookieLifetime { get; set; }

        /// <summary>
        /// Name of the cookie used for sticky sessions.
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("cookie_name")]
        [JsonRequired]
        public string CookieName { get; set; }

        /// <summary>
        /// Redirect HTTP requests to HTTPS. Only available if protocol is "https". Default <b>false</b>
        /// </summary>
        [JsonProperty("redirect_http")]
        public bool RedirectHttp { get; set; } = false;

        /// <summary>
        /// Use sticky sessions. Only available if protocol is "http" or "https". Default <b>false</b>
        /// </summary>
        [JsonProperty("sticky_sessions")]
        public bool StickySessions { get; set; } = false;
    }
}
