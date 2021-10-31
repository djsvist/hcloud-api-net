using hcloud_api.Services;
using hcloud_api.Services.Actions;
using System;
using System.Net.Http.Headers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AspNetExtensions
    {
        private const string clientName = "hcloud-api-net";

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

            return services;
        }
    }
}
