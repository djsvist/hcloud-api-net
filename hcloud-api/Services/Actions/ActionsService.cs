using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Requests.Actions;
using hcloud_api.Models.Responses;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    public abstract class ActionsService : IActionsService
    {
        protected readonly HttpClient client;

        public ActionsService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<HAction> GetAction(int resourceId, int actionId)
        {
            var result = await client.GetJsonAsync<ActionResponse>($"{BasePath}/{resourceId}/actions/{actionId}");
            return result.Action;
        }

        public async Task<GetActionsResponse> GetActions(int resourceId, ActionSortQuery sort = null, ActionStatus? status = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();

            query.AddNotNull("sort", sort);
            query.AddNotNull("status", status);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetActionsResponse>($"{BasePath}/{resourceId}/actions?" + query.ToQuery());
        }

        protected abstract string BasePath { get; }
    }
}
