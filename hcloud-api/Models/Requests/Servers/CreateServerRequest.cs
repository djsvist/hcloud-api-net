using hcloud_api.Models.Objects;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace hcloud_api.Models.Requests.Servers
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateServerRequest
    {
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены

        [JsonProperty("datacenter")]
        private string _datacenter;

        [JsonProperty("image")]
        [JsonRequired]
        private string _image;

        [JsonProperty("location")]
        private string _location;

        [JsonProperty("server_type")]
        [JsonRequired]
        private string _serverType;

        [JsonProperty("firewalls")]
        private IEnumerable<FirewallId> _firewalls;

#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены
        /// <summary>
        /// Auto-mount Volumes after attach
        /// </summary>
        [JsonProperty("automount")]
        public bool Automount { get; set; }

        /// <summary>
        /// Datacenter to create Server in (must not be used together with location)
        /// </summary>
        [JsonIgnore]
        public Datacenter Datacenter { set => _datacenter = value.Id.ToString(); }

        /// <summary>
        /// ID of Datacenter to create Server in (must not be used together with location)
        /// </summary>
        [JsonIgnore]
        public int DatacenterId { set => _datacenter = value.ToString(); }

        /// <summary>
        /// Name of Datacenter to create Server in (must not be used together with location)
        /// </summary>
        [JsonIgnore]
        public string DatacenterName { set => _datacenter = value; }

        /// <summary>
        /// Firewalls which should be applied on the Server's public network interface at creation time
        /// </summary>
        public IEnumerable<int> Firewalls
        {
            set => _firewalls = value.Select(id => new FirewallId(id)); //who came up with the idea of creating a separate object with a single field?
        }

        /// <summary>
        /// Image the Server is created from
        /// </summary>
        [JsonIgnore]
        public Image Image { set => _image = value.Id.ToString(); }

        /// <summary>
        /// ID of the Image the Server is created from
        /// </summary>
        [JsonIgnore]
        public int ImageId { set => _image = value.ToString(); }

        /// <summary>
        /// Name of the Image the Server is created from
        /// </summary>
        [JsonIgnore]
        public string ImageName { set => _image = value; }

        /// <summary>
        /// User-defined labels (key-value pairs)
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Location to create Server in (must not be used together with datacenter)
        /// </summary>
        [JsonIgnore]
        public Location Location { set => _location = value.Id.ToString(); }

        /// <summary>
        /// ID of Location to create Server in (must not be used together with datacenter)
        /// </summary>
        [JsonIgnore]
        public int LocationId { set => _location = value.ToString(); }

        /// <summary>
        /// Name of Location to create Server in (must not be used together with datacenter)
        /// </summary>
        [JsonIgnore]
        public string LocationName { set => _location = value; }

        /// <summary>
        /// Name of the Server to create (must be unique per Project and a valid hostname as per RFC 1123)
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// Network IDs which should be attached to the Server private network interface at the creation time
        /// </summary>
        [JsonProperty("networks")]
        public IEnumerable<int> Networks { get; set; }

        /// <summary>
        /// Server type this Server should be created with
        /// </summary>
        [JsonIgnore]
        public ServerType ServerType { set => _serverType = value.Id.ToString(); }

        /// <summary>
        /// ID of the Server type this Server should be created with
        /// </summary>
        [JsonIgnore]
        public int ServerTypeId { set => _serverType = value.ToString(); }

        /// <summary>
        /// Name of the Server type this Server should be created with
        /// </summary>
        [JsonIgnore]
        public string ServerTypeName { set => _serverType = value; }

        /// <summary>
        /// SSH key IDs (integer) or names (string) which should be injected into the Server at creation time
        /// </summary>
        [JsonProperty("ssh_keys")]
        public IEnumerable<string> SSHKeys { get; set; }

        /// <summary>
        /// Start Server right after creation. Defaults to true.
        /// </summary>
        [JsonProperty("start_after_create")]
        public bool StartAfterCreate { get; set; } = true;

        /// <summary>
        /// Cloud-Init user data to use during Server creation. This field is limited to 32KiB.
        /// </summary>
        [JsonProperty("user_data")]
        public string UserData { get; set; }

        /// <summary>
        /// Volume IDs which should be attached to the Server at the creation time.
        /// Volumes must be in the same Location.
        /// </summary>
        [JsonProperty("volumes")]
        public IEnumerable<int> Volumes { get; set; }

        private class FirewallId
        {
            /// <summary>
            /// ID of the Firewall
            /// </summary>
            [JsonProperty("firewall")]
            public int Firewall { get; set; }

            public FirewallId(int id) => Firewall = id;
        }
    }
}
