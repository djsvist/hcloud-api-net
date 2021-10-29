using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Certificates
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RenewalStatus
    {
        [EnumMember(Value = "scheduled")]
        Scheduled,

        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "failed")]
        Failed,

        [EnumMember(Value = "unavailable")]
        Unavailable
    }
}
