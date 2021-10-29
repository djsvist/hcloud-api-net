using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Certificates
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IssuanceStatus
    {
        [EnumMember(Value = "pending")]
        Pending,

        [EnumMember(Value = "completed")]
        Completed,

        [EnumMember(Value = "failed")]
        Failed
    }
}
