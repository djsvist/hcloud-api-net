﻿using hcloud_api.Models.Objects;
using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.FloatingIPs
{
    public class FloatingIPResponse : IResponse
    {
        [JsonProperty("floating_ip")]
        [JsonRequired]
        public FloatingIP FloatingIP { get; set; }
    }
}
