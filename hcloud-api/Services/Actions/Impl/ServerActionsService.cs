using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Images;
using hcloud_api.Models.Requests.Servers.Actions;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Servers.Actions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    public class ServerActionsService : ActionsService, IServerActionsService
    {
        private readonly HttpClient client;

        public ServerActionsService(HttpClient client) : base(client) { }

        protected override string BasePath => "servers";

        public async Task<HAction> AddToPlacementGroup(int serverId, int groupId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/add_to_placement_group", new
            {
                placement_group = groupId
            });
            return result.Action;
        }

        public async Task<HAction> AddToPlacementGroup(int serverId, PlacementGroup group)
        {
            return await AddToPlacementGroup(serverId, group.Id);
        }

        public async Task<HAction> AttachISO(int serverId, int isoId)
        {
            return await AttachISO(serverId, isoId.ToString());
        }

        public async Task<HAction> AttachISO(int serverId, string isoName)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/attach_iso", new
            {
                iso = isoName
            });
            return result.Action;
        }

        public async Task<HAction> AttachISO(int serverId, ISO iso)
        {
            return await AttachISO(serverId, iso.Id.ToString());
        }

        public async Task<HAction> AttachToNetwork(int serverId, int networkId, string ip = null, IEnumerable<string> aliasIps = null)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/attach_to_network", new AttachToNetworkRequest
            {
                AliasIPs = aliasIps,
                IP = ip,
                Network = networkId
            });
            return result.Action;
        }

        public async Task<HAction> AttachToNetwork(int serverId, Network network, string ip = null, IEnumerable<string> aliasIps = null)
        {
            return await AttachToNetwork(serverId, network.Id, ip, aliasIps);
        }

        public async Task<HAction> ChangeAliasIPs(int serverId, int networkId, IEnumerable<string> aliasIps)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/change_alias_ips", new
            {
                network = networkId,
                alias_ips = aliasIps
            });
            return result.Action;
        }

        public async Task<HAction> ChangeAliasIPs(int serverId, Network network, IEnumerable<string> aliasIps)
        {
            return await ChangeAliasIPs(serverId, network.Id, aliasIps);
        }

        public async Task<HAction> ChangeProtection(int serverId, bool? protectDelete = null, bool? protectRebuild = null)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/change_protection", new ChangeProtectionRequest
            {
                ProtectDelete = protectDelete,
                ProtectRebuild = protectRebuild
            });
            return result.Action;
        }

        public async Task<HAction> ChangeReverseDNS(int serverId, string ip, string dnsPointer)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/change_dns_ptr", new
            {
                ip,
                dns_ptr = dnsPointer
            });
            return result.Action;
        }

        public async Task<HAction> ChangeType(int serverId, string typeName, bool upgradeDisk)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/change_type", new
            {
                server_type = typeName,
                upgrade_disk = upgradeDisk
            });
            return result.Action;
        }

        public async Task<CreateImageResponse> CreateImage(int serverId, string description = null, Dictionary<string, string> labels = null, ImageType? type = null)
        {
            if (type != ImageType.Backup && type != ImageType.Snapshot && type != null)
                throw new ArgumentException("Image type can be Snapshot or Backup", nameof(type));

            return await client.PostJsonAsync<CreateImageResponse>($"{BasePath}/{serverId}/actions/create_image", new CreateImageRequest
            {
                Description = description,
                Labels = labels,
                Type = type
            });
        }

        public async Task<HAction> DetachFromNetwork(int serverId, int networkId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/detach_from_network", new
            {
                network = networkId
            });
            return result.Action;
        }

        public async Task<HAction> DetachISO(int serverId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/detach_iso");
            return result.Action;
        }

        public async Task<HAction> DisableBackups(int serverId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/disable_backup");
            return result.Action;
        }

        public async Task<HAction> DisableRescue(int serverId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/disable_rescue");
            return result.Action;
        }

        public async Task<HAction> EnableBackups(int serverId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/enable_backup");
            return result.Action;
        }

        public async Task<EnableRescueResponse> EnableRescue(int serverId, IEnumerable<int> sshKeys = null, RescueType? type = null)
        {
            return await client.PostJsonAsync<EnableRescueResponse>($"{BasePath}/{serverId}/actions/enable_rescue", new EnableRescueRequest
            {
                SSHKeys = sshKeys,
                Type = type
            });
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

        public async Task<RebuildServerResponse> Rebuild(int id, string imageName)
        {
            return await client.PostJsonAsync<RebuildServerResponse>($"servers/{id}/actions/rebuild", new
            {
                image = imageName
            });
        }

        public async Task<HAction> RemoveFromPlacementGroup(int serverId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{serverId}/actions/remove_from_placement_group");
            return result.Action;
        }

        public async Task<RequestConsoleResponse> RequestConsole(int serverId)
        {
            return await client.PostJsonAsync<RequestConsoleResponse>($"{BasePath}/{serverId}/actions/request_console");
        }

        public async Task<HAction> Reset(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/reset");
            return result.Action;
        }

        public async Task<ResetPasswordResponse> ResetPassword(int serverId)
        {
            return await client.PostJsonAsync<ResetPasswordResponse>($"{BasePath}/{serverId}/actions/reset_password");
        }

        public async Task<HAction> Shutdown(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"servers/{id}/actions/shutdown");
            return result.Action;
        }
    }
}
