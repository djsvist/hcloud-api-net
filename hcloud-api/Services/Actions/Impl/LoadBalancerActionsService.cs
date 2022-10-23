using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Requests.LoadBalancers.Actions;
using System.Net.Http;
using System.Threading.Tasks;
using ChangeProtectionRequest = hcloud_api.Models.Requests.LoadBalancers.Actions.ChangeProtectionRequest;

namespace hcloud_api.Services.Actions.Impl
{
    /// <summary>
    /// Implementation of ILoadBalancerActionsService
    /// </summary>
    public class LoadBalancerActionsService : ActionsService, ILoadBalancerActionsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public LoadBalancerActionsService(HttpClient client) : base(client)
        {
        }

        /// <inheritdoc />
        protected override string BasePath => "load_balancers";

        /// <inheritdoc />
        public Task<HAction> AddService(int lbId, AddServiceRequest request) => Execute("add_service", lbId, request);

        /// <inheritdoc />
        public Task<HAction> AddTarget(int lbId, AddTargetRequest request) => Execute("add_target", lbId, request);

        /// <inheritdoc />
        public Task<HAction> AttachToNetwork(int lbId, int networkId, string ip = null) => Execute("attach_to_network",
            lbId, new AttachToNetworkRequest
            {
                NetworkId = networkId,
                IP = ip
            });

        /// <inheritdoc />
        public Task<HAction> ChangeAlgorithm(int lbId, LBAlgorithmType algorithm) => Execute("change_algorithm", lbId,
            new ChangeAlgoritmRequest
            {
                Type = algorithm
            });

        /// <inheritdoc />
        public Task<HAction> ChangeDNSPointer(int lbId, string ip, string dnsPtr) => Execute("change_dns_ptr", lbId,
            new ChangeDNSPtrRequest
            {
                DNSPointer = dnsPtr,
                IP = ip
            });

        /// <inheritdoc />
        public Task<HAction> ChangeProtection(int lbId, bool delete) => Execute("change_protection", lbId,
            new ChangeProtectionRequest
            {
                Delete = delete
            });

        /// <inheritdoc />
        public Task<HAction> ChangeType(int lbId, int typeId) => Execute("change_type", lbId, new ChangeTypeRequest
        {
            TypeId = typeId
        });

        /// <inheritdoc />
        public Task<HAction> ChangeType(int lbId, string typeName) => Execute("change_type", lbId, new ChangeTypeRequest
        {
            TypeName = typeName
        });

        /// <inheritdoc />
        public Task<HAction> ChangeType(int lbId, LoadBalancerType type) => Execute("change_type", lbId,
            new ChangeTypeRequest
            {
                Type = type
            });

        /// <inheritdoc />
        public Task<HAction> DeleteService(int lbId, int listenPort) => Execute("delete_service", lbId,
            new DeleteServiceRequest
            {
                ListenPort = listenPort
            });

        /// <inheritdoc />
        public Task<HAction> DetachFromNetwork(int lbId, int networkId) => Execute("detach_from_network", lbId,
            new DetachFromNetworkRequest
            {
                NetworkId = networkId
            });

        /// <inheritdoc />
        public Task<HAction> DisablePublicInterface(int lbId) => Execute("disable_public_interface", lbId);

        /// <inheritdoc />
        public Task<HAction> EnablePublicInterface(int lbId) => Execute("enable_public_interface", lbId);

        /// <inheritdoc />
        public Task<HAction> RemoveTarget(int lbId, RemoveTargetRequest request) =>
            Execute("remove_target", lbId, request);

        /// <inheritdoc />
        public Task<HAction> UpdateService(int lbId, UpdateServiceRequest request) =>
            Execute("update_service", lbId, request);
    }
}
