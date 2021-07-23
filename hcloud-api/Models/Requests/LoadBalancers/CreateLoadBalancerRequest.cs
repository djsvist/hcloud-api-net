using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Objects.LoadBalancers.Services;
using hcloud_api.Models.Objects.LoadBalancers.Targets;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace hcloud_api.Models.Requests.LoadBalancers
{
    public class CreateLoadBalancerRequest
    {
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены
        [JsonProperty("load_balancer_type")]
        [JsonRequired]
        private string _loadBalancerType;
#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены

        /// <summary>
        /// Algorithm of the Load Balancer
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("algorithm")]
        [JsonRequired]
        public LBAlgorithm Algorithm { get; set; }

        /// <summary>
        /// User-defined labels
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Load Balancer type this Load Balancer should be created with
        /// </summary>
        [JsonIgnore]
        public LoadBalancerType LoadBalancerType { set => _loadBalancerType = value.Id.ToString(); }

        /// <summary>
        /// ID of the Load Balancer type this Load Balancer should be created with
        /// </summary>
        [JsonIgnore]
        public int LoadBalancerTypeId { set => _loadBalancerType = value.ToString(); }

        /// <summary>
        /// Name of the Load Balancer type this Load Balancer should be created with
        /// </summary>
        [JsonIgnore]
        public string LoadBalancerTypeName { set => _loadBalancerType = value; }

        /// <summary>
        /// Name of the Load Balancer
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// ID of the network the Load Balancer should be attached to on creation
        /// </summary>
        [JsonProperty("network")]
        public int? Network { get; set; }

        /// <summary>
        /// Name of network zone
        /// </summary>
        [JsonProperty("network_zone")]
        public string NetworkZone { get; set; }

        /// <summary>
        /// Enable or disable the public interface of the Load Balancer
        /// </summary>
        [JsonProperty("public_interface")]
        public bool PublicInterface { get; set; } = true;

        /// <summary>
        /// Array of services
        /// </summary>
        [JsonProperty("services")]
        public IEnumerable<LoadBalancerService> Services { get; set; }

        /// <summary>
        /// Array of targets
        /// </summary>
        [JsonProperty("targets")]
        public IEnumerable<LoadBalancerTarget> Targets { get; set; }
    }
}
