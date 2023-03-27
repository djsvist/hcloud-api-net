using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteServiceRequest
    {
        /// <summary>
        /// The listen port of the service you want to delete
        /// </summary>
        [JsonProperty("listen_port")]
        public int ListenPort { get; set; }
    }
}
