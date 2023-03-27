using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Images.Actions;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of image actions
    /// </summary>
    public class ImageActionsService : ActionsService, IImageActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public ImageActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "images";

        /// <inheritdoc />
        public Task<HAction> ChangeProtection(int imageId, bool delete) => Execute("change_protection", imageId,
            new ChangeProtectionRequest
            {
                Delete = delete
            });
    }
}
