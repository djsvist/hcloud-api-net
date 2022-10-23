using hcloud_api.Services;
using hcloud_api.Services.Actions;
using hcloud_api.Services.Actions.Impl;
using System;
using System.Net.Http.Headers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AspNetExtensions
    {
        private const string clientName = "hcloud-api-net";

        /// <summary>
        /// Add services for Hetzner API
        /// </summary>
        /// <param name="services"></param>
        /// <param name="token">Your API token</param>
        /// <param name="baseUri"></param>
        /// <returns></returns>
        public static IServiceCollection UseHCloudAPI(this IServiceCollection services, string token, string baseUri = "https://api.hetzner.cloud/v1/")
        {
            services.AddHttpClient(clientName, c =>
            {
                c.BaseAddress = new Uri(baseUri);
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                c.DefaultRequestHeaders.Add("User-Agent", clientName);
            });

            services.AddHttpClient<IHCloudService, HCloudService>(clientName);
            services.AddHttpClient<IServerActionsService, ServerActionsService>(clientName);
            services.AddHttpClient<ICertificateActionsService, CertificateActionsService>(clientName);
            services.AddHttpClient<IVolumeActionsService, VolumeActionsService>(clientName);
            services.AddHttpClient<INetworkActionsService, NetworkActionsService>(clientName);
            services.AddHttpClient<ILoadBalancerActionsService, LoadBalancerActionsService>(clientName);
            services.AddHttpClient<IFirewallActionsService, FirewallActionsService>(clientName);
            services.AddHttpClient<IFloatingIPActionsService, FloatingIPActionsService>(clientName);

            return services;
        }
    }
}
