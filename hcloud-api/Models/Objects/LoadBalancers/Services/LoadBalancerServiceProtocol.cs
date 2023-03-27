using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.LoadBalancers.Services
{
    /// <summary>
    /// Protocol of the Load Balancer
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoadBalancerServiceProtocol
    {
        [EnumMember(Value = "tcp")]
        Tcp,

        [EnumMember(Value = "http")]
        Http,

        [EnumMember(Value = "https")]
        Https
    }
}
