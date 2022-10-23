using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.LoadBalancers.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeTypeRequest
    {
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены
        [JsonProperty("load_balancer_type")]
        private string type;
#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены

        /// <summary>
        /// Name of Load Balancer type the Load Balancer should migrate to
        /// </summary>
        [JsonIgnore]
        public string TypeName
        {
            set => type = value;
        }

        /// <summary>
        /// ID of Load Balancer type the Load Balancer should migrate to
        /// </summary>
        [JsonIgnore]
        public int TypeId
        {
            set => type = value.ToString();
        }

        /// <summary>
        /// Load Balancer type the Load Balancer should migrate to
        /// </summary>
        [JsonIgnore]
        public LoadBalancerType Type
        {
            set => type = value.Id.ToString();
        }
    }
}
