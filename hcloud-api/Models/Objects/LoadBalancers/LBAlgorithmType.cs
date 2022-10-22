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
        [EnumMember(Value = "round_robin")]
        Round_robin,

        [EnumMember(Value = "least_connections")]
        Least_connections
    }
}
