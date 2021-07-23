using hcloud_api.Models.Objects.LoadBalancers.HealthChecks;
using Newtonsoft.Json;

namespace hcloud_api.Models.Objects.LoadBalancers.Services
{
    public class LoadBalancerService
    {
        /// <summary>
        /// Port the Load Balancer will balance to
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("destination_port")]
        public int DestinationPort { get; set; }

        /// <summary>
        /// Service health check
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("health_check")]
        [JsonRequired]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Configuration option for protocols http and https
        /// </summary>
        [JsonProperty("http", NullValueHandling = NullValueHandling.Ignore)]
        public HttpCfg HttpConfiguration { get; set; }

        /// <summary>
        /// Port the Load Balancer listens on
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("listen_port")]
        [JsonRequired]
        public int ListenPort { get; set; }

        /// <summary>
        /// Protocol of the Load Balancer
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("protocol")]
        [JsonRequired]
        public LoadBalancerServiceProtocol Protocol { get; set; }

        /// <summary>
        /// Is Proxyprotocol enabled or not
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("proxyprotocol")]
        [JsonRequired]
        public bool ProxyProtocol { get; set; }
    }
}
