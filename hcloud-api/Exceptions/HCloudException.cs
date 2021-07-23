using hcloud_api.Models.Objects.Shared;
using System;

namespace hcloud_api.Exceptions
{
    public class HCloudException : Exception
    {
        public Error Error { get; set; }
    }
}
