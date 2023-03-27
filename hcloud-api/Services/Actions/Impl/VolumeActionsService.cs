using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Volumes.Actions;
using hcloud_api.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of volume actions
    /// </summary>
    public class VolumeActionsService : ActionsService, IVolumeActionsService
    {
        /// <inheritdoc />
        public VolumeActionsService(HttpClient client) : base(client) { }

        /// <inheritdoc />
        protected override string BasePath => "volumes";

        /// <inheritdoc />
        public async Task<HAction> AttachVolume(int volumeId, int serverId, bool automount = false)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{volumeId}/actions/attach", new AttachToServerRequest
            {
                Server = serverId,
                Automount = automount
            });
            return result.Action;
        }

        /// <inheritdoc />
        public Task<HAction> AttachVolume(Volume volume, int serverId, bool automount = false) =>
            AttachVolume(volume.Id, serverId, automount);

        /// <inheritdoc />
        public async Task<HAction> ChangeProtection(int volumeId, bool delete)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{volumeId}/actions/change_protection", new ChangeProtectionRequest
            {
                Delete = delete
            });
            return result.Action;
        }

        /// <inheritdoc />
        public Task<HAction> ChangeProtection(Volume volume, bool delete) => ChangeProtection(volume.Id, delete);

        /// <inheritdoc />
        public async Task<HAction> Detach(int volumeId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{volumeId}/actions/detach");
            return result.Action;
        }

        /// <inheritdoc />
        public Task<HAction> Detach(Volume volume) => Detach(volume.Id);

        /// <inheritdoc />
        public async Task<HAction> Resize(int volumeId, int size)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{volumeId}/actions/resize", new ResizeRequest
            {
                Size = size
            });
            return result.Action;
        }

        /// <inheritdoc />
        public Task<HAction> Resize(Volume volume, int size) => Resize(volume.Id, size);
    }
}
