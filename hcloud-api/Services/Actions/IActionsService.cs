using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Requests.Actions;
using hcloud_api.Models.Responses;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    public interface IActionsService
    {
        /// <summary>
        /// Returns all Action objects for a resource.
        /// You can sort the results by using the sort URI parameter, and filter them with the <b>status</b> parameter.
        /// </summary>
        /// <param name="resourceId">ID of the Resource</param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        Task<GetActionsResponse> GetActions(int resourceId,
            ActionSortQuery sort = null,
            ActionStatus? status = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Returns a specific Action object for a resource.
        /// </summary>
        /// <param name="resourceId">ID of the Resource</param>
        /// <param name="actionId">ID of the Action</param>
        /// <returns></returns>
        Task<HAction> GetAction(int resourceId, int actionId);
    }
}
