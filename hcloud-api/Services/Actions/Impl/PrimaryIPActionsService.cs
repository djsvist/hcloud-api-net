using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.PrimaryIPs;
using hcloud_api.Models.Requests.PrimaryIPs.Actions;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of primary ip actions
    /// </summary>
    public class PrimaryIPActionsService : ActionsService, IPrimaryIPActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public PrimaryIPActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "primary_ips";

        /// <inheritdoc />
        public Task<HAction> AssignTo(int ipId, int assigneeId, AssigneeType assigneeType) => Execute("", ipId,
            new AssignRequest
            {
                AssigneeId = assigneeId,
                AssigneeType = assigneeType
            });

        /// <inheritdoc />
        public Task<HAction> ChangeDNSPointer(int ipId, string ip, string dnsPtr) => Execute("", ipId,
            new ChangeDNSPtrRequest
            {
                IP = ip,
                DNSPointer = dnsPtr
            });

        /// <inheritdoc />
        public Task<HAction> ChangeProtection(int ipId, bool delete) => Execute("", ipId, new ChangeProtectionRequest
        {
            Delete = delete
        });

        /// <inheritdoc />
        public Task<HAction> Unassign(int ipId) => Execute("", ipId);
    }
}
