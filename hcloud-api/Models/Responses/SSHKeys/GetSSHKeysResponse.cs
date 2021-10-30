using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.SSHKeys
{
    public class GetSSHKeysResponse : IResponse
    {
        [JsonProperty("ssh_keys")]
        [JsonRequired]
        public SSHKey Keys { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
