using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers.HealthChecks
{
    public class HealthCheck
    {
        /// <summary>
        /// Additional configuration for protocol http
        /// </summary>
        [JsonProperty("http", NullValueHandling = NullValueHandling.Ignore)]
        public HealthCheckHttpCfg Http { get; set; }

        /// <summary>
        /// Time interval in seconds health checks are performed
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("interval")]
        [JsonRequired]
        public int Interval { get; set; }

        /// <summary>
        /// Port the health check will be performed on
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("port")]
        [JsonRequired]
        public int Port { get; set; }

        /// <summary>
        /// Type of the health check
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("protocol")]
        [JsonRequired]
        public HealthCheckProtocol Protocol { get; set; }

        /// <summary>
        /// Unsuccessful retries needed until a target is considered unhealthy; an unhealthy target needs the same number of successful retries to become healthy again
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("retries")]
        [JsonRequired]
        public int Retries { get; set; }

        /// <summary>
        /// Time in seconds after an attempt is considered a timeout
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("timeout")]
        [JsonRequired]
        public int Timeout { get; set; }
    }
}
