using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Objects.Images;
using hcloud_api.Models.Requests.Actions;
using hcloud_api.Models.Requests.Servers.Actions;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Servers.Actions;

namespace hcloud_api.Services.Actions
{
    public class ServerActionsService : IServerActionsService
    {
        private readonly HttpClient client;

        public ServerActionsService(HttpClient client)
        {
            this.client = client;
        }

        public Task<HAction> AddToPlacementGroup(int serverId, int groupId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AddToPlacementGroup(int serverId, PlacementGroup group)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AttachISO(int serverId, int isoId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AttachISO(int serverId, string isoName)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AttachISO(int serverId, ISO iso)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AttachToNetwork(int serverId, int networkId, string ip = null, IEnumerable<string> aliasIps = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> AttachToNetwork(int serverId, Network network, string ip = null, IEnumerable<string> aliasIps = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> ChangeAliasIPs(int serverId, int networkId, IEnumerable<string> aliasIps)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> ChangeAliasIPs(int serverId, Network network, IEnumerable<string> aliasIps)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> ChangeProtection(int serverId, bool? protectDelete = null, bool? protectRebuild = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> ChangeReverseDNS(int serverId, string ip, string dnsPointer)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> ChangeType(int serverId, string typeName, bool upgradeDisk)
        {
            throw new System.NotImplementedException();
        }

        public Task<CreateImageResponse> CreateImage(int serverId, string description = null, Dictionary<string, string> labels = null, ImageType? type = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> DetachFromNetwork(int serverId, int networkId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> DetachISO(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> DisableBackups(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> DisableRescue(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> EnableBackups(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public Task<EnableRescueResponse> EnableRescue(int serverId, IEnumerable<int> sshKeys = null, RescueType? type = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> GetAction(int serverId, int actionId)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetActionsResponse> GetActions(int serverId, ActionSortQuery sort = null, ActionStatus? status = null, int? page = null, int? perPage = null)
        {
            throw new System.NotImplementedException();
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

        public Task<RebuildServerResponse> Rebuild(int id, string imageName)
        {
            throw new System.NotImplementedException();
        }

        public Task<HAction> RemoveFromPlacementGroup(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public Task<RequestConsoleResponse> RequestConsole(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<HAction> Reset(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/reset");
            return result.Action;
        }

        public Task<ResetPasswordResponse> ResetPassword(int serverId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<HAction> Shutdown(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/shutdown");
            return result.Action;
        }
    }
}
