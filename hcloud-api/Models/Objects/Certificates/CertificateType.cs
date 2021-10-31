using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace hcloud_api.Models.Objects.Certificates
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateType
    {
        [EnumMember(Value = "uploaded")]
        Uploaded,

        [EnumMember(Value = "managed")]
        Managed
    }
}
