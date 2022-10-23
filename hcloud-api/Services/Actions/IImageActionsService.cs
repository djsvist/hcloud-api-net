using hcloud_api.Models.Objects;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Image actions
    /// </summary>
    public interface IImageActionsService : IActionsService
    {
        /// <summary>
        /// Changes the protection configuration of the Image. Can only be used on snapshots.
        /// </summary>
        /// <param name="imageId">ID of the Image</param>
        /// <param name="delete">If true, prevents the snapshot from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int imageId, bool delete);
    }
}
