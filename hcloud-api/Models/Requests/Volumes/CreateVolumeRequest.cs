using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Volumes;
using Newtonsoft.Json;

namespace hcloud_api.Models.Requests.Volumes
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateVolumeRequest
    {
#pragma warning disable IDE0052 // Удалить непрочитанные закрытые члены
        [JsonProperty("location")]
        private string _location;
#pragma warning restore IDE0052 // Удалить непрочитанные закрытые члены

        /// <summary>
        /// Auto-mount Volumes after attach
        /// </summary>
        [JsonProperty("automount")]
        public bool Automount { get; set; }

        /// <summary>
        /// Name of the volume
        /// <br><b>Required field</b></br>
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

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
        /// Server to which to attach the Volume once it's created (Volume will be created in the same Location as the server)
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Size in GB of the Volume
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Format Volume after creation
        /// </summary>
        [JsonProperty("format")]
        public VolumeFormat? Format { get; set; }
    }
}
