using hcloud_api.Models.Objects;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    public interface ISertificateActionsService : IActionsService
    {
        /// <summary>
        /// Retry a failed Certificate issuance or renewal.
        /// <br />
        /// Only applicable if the type of the Certificate is <b>managed</b> and the issuance or renewal status is <b>failed</b>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<HAction> RetryIssuanceOrRenewal(int id);
    }
}
