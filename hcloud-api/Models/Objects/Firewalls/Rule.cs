using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Objects.Firewalls
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Rule
    {
        /// <summary>
        /// List of permitted IPv4/IPv6 addresses in CIDR notation.
        /// Use <b>0.0.0.0/0</b> to allow all IPv4 addresses and <b>::/0</b> to allow all IPv6 addresses. You can specify 100 CIDRs at most.
        /// </summary>
        [JsonProperty("destination_ips")]
        public IList<string> DestinationIps { get; set; }

        /// <summary>
        /// Select traffic direction on which rule should be applied. Use <b>source_ips</b> for direction <b>in</b> and <b>destination_ips</b> for direction <b>out</b>.
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("direction")]
        [JsonRequired]
        public RuleDirection Direction { get; set; }

        /// <summary>
        /// Port or port range to which traffic will be allowed, only applicable for protocols TCP and UDP. A port range can be specified by separating two ports with a dash, e.g <b>1024-5000</b>
        /// </summary>
        [JsonProperty("port")]
        public string Port { get; set; }

        /// <summary>
        /// Type of traffic to allow
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("protocol")]
        [JsonRequired]
        public RuleProtocol Protocol { get; set; }

        /// <summary>
        /// List of permitted IPv4/IPv6 addresses in CIDR notation.
        /// Use <b>0.0.0.0/0</b> to allow all IPv4 addresses and <b>::/0</b> to allow all IPv6 addresses. You can specify 100 CIDRs at most.
        /// </summary>
        [JsonProperty("source_ips")]
        public IList<string> SourceIps { get; set; }
    }
}
