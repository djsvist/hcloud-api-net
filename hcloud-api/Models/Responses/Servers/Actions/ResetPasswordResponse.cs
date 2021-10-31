using System;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Servers.Actions
{
    public class ResetPasswordResponse : ActionResponse
    {
        /// <summary>
        /// Password that will be set for this Server once the Action succeeds
        /// </summary>
        [JsonProperty("root_password")]
        public string RootPassword { get; set; }
    }
}
