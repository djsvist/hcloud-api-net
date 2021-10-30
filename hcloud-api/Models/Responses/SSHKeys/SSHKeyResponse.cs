using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.SSHKeys
{
    public class SSHKeyResponse : IResponse
    {
        /// <summary>
        /// SSH key
        /// </summary>
        [JsonProperty("ssh_key")]
        [JsonRequired]
        public SSHKey Key { get; set; }
    }
}
