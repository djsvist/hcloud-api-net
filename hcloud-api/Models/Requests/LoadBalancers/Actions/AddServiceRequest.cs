using hcloud_api.Models.Objects.LoadBalancers.HealthChecks;
using hcloud_api.Models.Objects.LoadBalancers.Services;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class AddServiceRequest
    {
        /// <summary>
        /// Port the Load Balancer will balance to<br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("destination_port")]
        [JsonRequired]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Service health check <br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("health_check")]
        [JsonRequired]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Configuration option for protocols http and https
        /// </summary>
        [JsonProperty("http")]
        public HttpCfg Http { get; set; }

        /// <summary>
        /// Port the Load Balancer listens on<br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("listen_port")]
        [JsonRequired]
        public int? ListenPort { get; set; }

        /// <summary>
        /// Protocol of the Load Balancer<br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("protocol")]
        [JsonRequired]
        public LoadBalancerServiceProtocol? Protocol { get; set; }

        /// <summary>
        /// Is Proxyprotocol enabled or not<br/>
        /// <b>Required field</b>
        /// </summary>
        [JsonProperty("proxyprotocol")]
        [JsonRequired]
        public bool? ProxyProtocol { get; set; }
    }
}
