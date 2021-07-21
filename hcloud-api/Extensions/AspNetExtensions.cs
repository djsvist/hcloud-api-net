using hcloud_api.Services.Impl;
using hcloud_api.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http.Headers;

namespace hcloud_api
{
    public static class AspNetExtensions
    {
        public static IServiceCollection UseHCloudAPI(this IServiceCollection services, string token, string baseUri = "https://api.hetzner.cloud/v1/")
        {
            services.AddHttpClient<IServerService, ServerService>(c =>
            {
                c.BaseAddress = new Uri(baseUri);
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                c.DefaultRequestHeaders.Add("User-Agent", "hcloud-api-net");
            });
            return services;
        }
    }
}
