using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Responses;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of certificate actions
    /// </summary>
    public class CertificateActionsService : ActionsService, ICertificateActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public CertificateActionsService(HttpClient client) : base(client) { }

        /// <inheritdoc />
        protected override string BasePath => "certificates";

        /// <inheritdoc />
        public async Task<HAction> RetryIssuanceOrRenewal(int id)
        {
            var result = await client.PostJsonAsync<ActionResponse>($"{BasePath}/{id}/actions/retry");
            return result.Action;
        }
    }
}
