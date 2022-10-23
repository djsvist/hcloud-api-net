using hcloud_api.Models.Objects;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Volume actions
    /// </summary>
    public interface IVolumeActionsService : IActionsService
    {
        /// <summary>
        /// Attaches a Volume to a Server. Works only if the Server is in the same Location as the Volume.
        /// </summary>
        /// <param name="volumeId">ID of the Volume</param>
        /// <param name="serverId">ID of the Server the Volume will be attached to</param>
        /// <param name="automount">Auto-mount the Volume after attaching it</param>
        /// <returns></returns>
        Task<HAction> AttachVolume(int volumeId, int serverId, bool automount = false);

        /// <summary>
        /// Attaches a Volume to a Server. Works only if the Server is in the same Location as the Volume.
        /// </summary>
        /// <param name="volume">Volume</param>
        /// <param name="serverId">ID of the Server the Volume will be attached to</param>
        /// <param name="automount">Auto-mount the Volume after attaching it</param>
        /// <returns></returns>
        Task<HAction> AttachVolume(Volume volume, int serverId, bool automount = false);

        /// <summary>
        /// Changes the protection configuration of a Volume.
        /// </summary>
        /// <param name="volumeId">ID of the Volume</param>
        /// <param name="delete">If true, prevents the Volume from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int volumeId, bool delete);

        /// <summary>
        /// Changes the protection configuration of a Volume.
        /// </summary>
        /// <param name="volume">Volume</param>
        /// <param name="delete">If true, prevents the Volume from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(Volume volume, bool delete);

        /// <summary>
        /// Detaches a Volume from the Server it’s attached to. You may attach it to a Server again at a later time
        /// </summary>
        /// <param name="volumeId">ID of the Volume</param>
        /// <returns></returns>
        Task<HAction> Detach(int volumeId);

        /// <summary>
        /// Detaches a Volume from the Server it’s attached to. You may attach it to a Server again at a later time
        /// </summary>
        /// <param name="volume">Volume</param>
        /// <returns></returns>
        Task<HAction> Detach(Volume volume);

        /// <summary>
        /// Changes the size of a Volume. Note that downsizing a Volume is not possible.
        /// </summary>
        /// <param name="volumeId">Volume</param>
        /// <param name="size">New Volume size in GB (must be greater than current size)</param>
        /// <returns></returns>
        Task<HAction> Resize(int volumeId, int size);

        /// <summary>
        /// Changes the size of a Volume. Note that downsizing a Volume is not possible.
        /// </summary>
        /// <param name="volume">Volume</param>
        /// <param name="size">New Volume size in GB (must be greater than current size)</param>
        /// <returns></returns>
        Task<HAction> Resize(Volume volume, int size);
    }
}
