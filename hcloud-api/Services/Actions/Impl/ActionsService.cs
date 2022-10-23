using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Requests.Actions;
using hcloud_api.Models.Responses;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Base actions class
    /// </summary>
    public abstract class ActionsService : IActionsService
    {
        /// <summary>
        /// http client
        /// </summary>
        protected readonly HttpClient client;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        protected ActionsService(HttpClient client)
        {
            this.client = client;
        }

        /// <inheritdoc />
        public async Task<HAction> GetAction(int resourceId, int actionId)
        {
            var result = await client.GetJsonAsync<ActionResponse>($"{BasePath}/{resourceId}/actions/{actionId}");
            return result.Action;
        }

        /// <inheritdoc />
        public async Task<GetActionsResponse> GetActions(int resourceId, ActionSortQuery sort = null, ActionStatus? status = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();

            query.AddNotNull("sort", sort);
            query.AddNotNull("status", status);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetActionsResponse>($"{BasePath}/{resourceId}/actions?" + query.ToQuery());
        }

        /// <summary>
        /// Execute action request
        /// </summary>
        /// <param name="action">Action name</param>
        /// <param name="resourceId"></param>
        /// <param name="request">Request data</param>
        /// <returns></returns>
        protected async Task<HAction> Execute<T>(string action, int resourceId, T request)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{resourceId}/actions/{action}", request);
            return result.Action;
        }

        /// <summary>
        /// Execute action request
        /// </summary>
        /// <param name="action">Action name</param>
        /// <param name="resourceId"></param>
        /// <returns></returns>
        protected async Task<HAction> Execute(string action, int resourceId)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{resourceId}/actions/{action}");
            return result.Action;
        }

        /// <summary>
        /// Base path of actions url
        /// </summary>
        protected abstract string BasePath { get; }
    }
}
