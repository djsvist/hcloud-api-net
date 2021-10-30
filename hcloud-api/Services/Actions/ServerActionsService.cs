using System.Net.Http;
using System.Threading.Tasks;
using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Responses;

namespace hcloud_api.Services.Actions
{
    public class ServerActionsService : IServerActionsService
    {
        private readonly HttpClient client;

        public ServerActionsService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<HAction> PowerOff(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/poweroff");
            return result.Action;
        }

        public async Task<HAction> PowerOn(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/poweron");
            return result.Action;
        }

        public async Task<HAction> Reboot(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/reboot");
            return result.Action;
        }

        public async Task<HAction> Reset(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/reset");
            return result.Action;
        }

        public async Task<HAction> Shutdown(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"sservers/{id}/actions/shutdown");
            return result.Action;
        }
    }
}
