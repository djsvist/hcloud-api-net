using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    public class SertificateActionsService : ActionsService, ISertificateActionsService
    {
        public SertificateActionsService(HttpClient client) : base(client) { }

        protected override string BasePath => "certificates";

        public async Task<HAction> RetryIssuanceOrRenewal(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{id}/actions/retry");
            return result.Action;
        }
    }
}
