using hcloud_api.Services;
using hcloud_api.Services.Actions;
using System;
using System.Net.Http.Headers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AspNetExtensions
    {
        public static IServiceCollection UseHCloudAPI(this IServiceCollection services, string token, string baseUri = "https://api.hetzner.cloud/v1/")
        {
            services.AddHttpClient<IHCloudService, HCloudService>(c =>
            {
                c.BaseAddress = new Uri(baseUri);
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                c.DefaultRequestHeaders.Add("User-Agent", "hcloud-api-net");
            });

            services.AddHttpClient<IServerActionsService, ServerActionsService>(c =>
            {
                c.BaseAddress = new Uri(baseUri);
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                c.DefaultRequestHeaders.Add("User-Agent", "hcloud-api-net");
            });

            return services;
        }
    }
}
