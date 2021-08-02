﻿using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Volumes
{
    public class VolumeResponse : IResponse
    {
        [JsonProperty("volume")]
        public Volume Volume { get; set; }
    }
}
