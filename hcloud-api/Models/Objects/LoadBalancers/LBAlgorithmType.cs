using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers
{
    /// <summary>
    /// Algorithm of the Load Balancer
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LBAlgorithmType
    {
        [Obsolete]
        [EnumMember(Value = "round_robin")]
        Round_robin,

        [Obsolete]
        [EnumMember(Value = "least_connections")]
        Least_connections,

        [EnumMember(Value = "round_robin")]
        RoundRobin,

        [EnumMember(Value = "least_connections")]
        LeastConnections
    }
}
