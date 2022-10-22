using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Networks;
using hcloud_api.Models.Requests.Networks.Actions;
using hcloud_api.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class NetworkActionsService : ActionsService, INetworkActionsService
    {
        /// <inheritdoc />
        public NetworkActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "networks";

        /// <inheritdoc />
        public async Task<HAction> AddRoute(int networkId, string destination, string gateway)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/add_route", new AddRouteRequest
            {
                Destination = destination,
                Gateway = gateway
            });
            return result.Action;
        }

        /// <inheritdoc />
        public Task<HAction> AddRoute(Network network, string destination, string gateway) =>
            AddRoute(network.Id, destination, gateway);

        /// <inheritdoc />
        public async Task<HAction> AddSubnet(int networkId, string networkZone, SubnetType type, string ipRange = null, int? vSwitchId = null)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/add_subnet", new AddSubnetRequest
            {
                NetworkZone = networkZone,
                Type = type,
                IpRange = ipRange,
                VSwitchId = vSwitchId
            });
            return result.Action;
        }

        /// <inheritdoc />
        public async Task<HAction> ChangeIpRange(int networkId, string ipRange)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/change_ip_range", new ChangeIpRangeRequest
            {
                IpRange = ipRange
            });
            return result.Action;
        }

        /// <inheritdoc />
        public async Task<HAction> ChangeProtection(int networkId, bool delete)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/change_protection", new ChangeProtectionRequest
            {
                Delete = delete
            });
            return result.Action;
        }

        /// <inheritdoc />
        public async Task<HAction> DeleteRoute(int networkId, string destination, string gateway)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/delete_route", new DeleteRouteRequest
            {
                Destination = destination,
                Gateway = gateway
            });
            return result.Action;
        }

        /// <inheritdoc />
        public async Task<HAction> DeleteSubnet(int networkId, string ipRange)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{networkId}/actions/delete_subnet", new DeleteSubnetRequest
            {
                IpRange = ipRange
            });
            return result.Action;
        }
    }
}
