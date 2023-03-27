using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Actions
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionStatus
    {
        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "running")]
        Running,

        [EnumMember(Value = "error")]
        Error
    }
}
