using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.FloatingIPs.Actions;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of floating ip actions
    /// </summary>
    public class FloatingIPActionsService : ActionsService, IFloatingIPActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public FloatingIPActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "floating_ips";

        /// <inheritdoc />
        public Task<HAction> Assign(int id, int serverId) => Execute("assign", id, new AssignToServerRequest
        {
            ServerId = serverId
        });

        /// <inheritdoc />
        public Task<HAction> ChangeDNSPointer(int id, string ip, string dnsPtr) => Execute("change_dns_ptr", id,
            new ChangeDNSPtrRequest
            {
                IP = ip,
                DNSPointer = dnsPtr
            });

        /// <inheritdoc />
        public Task<HAction> ChangeProtection(int id, bool delete) => Execute("change_protection", id,
            new ChangeProtectionRequest
            {
                Delete = delete
            });

        /// <inheritdoc />
        public Task<HAction> Unassign(int id) => Execute("unassign", id);
    }
}
