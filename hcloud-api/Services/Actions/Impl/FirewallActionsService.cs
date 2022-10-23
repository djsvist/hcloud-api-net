using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Firewalls.Actions;
using hcloud_api.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of firewall actions
    /// </summary>
    public class FirewallActionsService : ActionsService, IFirewallActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public FirewallActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "firewalls";

        /// <inheritdoc />
        public async Task<HAction[]> ApplyToResources(int firewallId, ApplyToResourcesRequest request)
        {
            var result = await client.PostJsonAsync<ActionsResponse>($"{BasePath}/{firewallId}/actions/apply_to_resources", request);
            return result.Actions;
        }

        /// <inheritdoc />
        public async Task<HAction[]> RemoveFromResources(int firewallId, RemoveFromResourcesRequest request)
        {
            var result = await client.PostJsonAsync<ActionsResponse>($"{BasePath}/{firewallId}/actions/remove_from_resources", request);
            return result.Actions;
        }

        /// <inheritdoc />
        public async Task<HAction[]> SetRules(int firewallId, SetRulesRequest request)
        {
            var result = await client.PostJsonAsync<ActionsResponse>($"{BasePath}/{firewallId}/actions/set_rules", request);
            return result.Actions;
        }
    }
}
