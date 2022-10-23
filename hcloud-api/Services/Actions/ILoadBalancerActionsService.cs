using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.LoadBalancers;
using hcloud_api.Models.Requests.LoadBalancers.Actions;
using System.Threading.Tasks;
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILoadBalancerActionsService : IActionsService
    {
        /// <summary>
        /// Adds a service to a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction> AddService(int lbId, AddServiceRequest request);

        /// <summary>
        /// Adds a target to a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction> AddTarget(int lbId, AddTargetRequest request);

        /// <summary>
        /// Attach a Load Balancer to a Network.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="networkId">ID of an existing network to attach the Load Balancer to</param>
        /// <param name="ip">IP to request to be assigned to this Load Balancer; if you do not provide this then you will be auto assigned an IP address</param>
        /// <returns></returns>
        Task<HAction> AttachToNetwork(int lbId, int networkId, string ip = null);

        /// <summary>
        /// Change the algorithm that determines to which target new requests are sent.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="algorithm">Algorithm of the Load Balancer</param>
        /// <returns></returns>
        Task<HAction> ChangeAlgorithm(int lbId, LBAlgorithmType algorithm);

        /// <summary>
        /// Changes the hostname that will appear when getting the hostname belonging to the public IPs (IPv4 and IPv6) of this Load Balancer.<br/>
        /// Floating IPs assigned to the Server are not affected by this.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="ip">Public IP address for which the reverse DNS entry should be set</param>
        /// <param name="dnsPtr">Hostname to set as a reverse DNS PTR entry</param>
        /// <returns></returns>
        Task<HAction> ChangeDNSPointer(int lbId, string ip, string dnsPtr);

        /// <summary>
        /// Changes the protection configuration of a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="delete">If true, prevents the Load Balancer from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int lbId, bool delete);

        /// <summary>
        /// Changes the type (Max Services, Max Targets and Max Connections) of a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="typeId">ID of Load Balancer type the Load Balancer should migrate to</param>
        /// <returns></returns>
        Task<HAction> ChangeType(int lbId, int typeId);

        /// <summary>
        /// Changes the type (Max Services, Max Targets and Max Connections) of a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="typeName">Name of Load Balancer type the Load Balancer should migrate to</param>
        /// <returns></returns>
        Task<HAction> ChangeType(int lbId, string typeName);

        /// <summary>
        /// Changes the type (Max Services, Max Targets and Max Connections) of a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="type">Load Balancer type the Load Balancer should migrate to</param>
        /// <returns></returns>
        Task<HAction> ChangeType(int lbId, LoadBalancerType type);

        /// <summary>
        /// Delete a service of a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="listenPort">The listen port of the service you want to delete</param>
        /// <returns></returns>
        Task<HAction> DeleteService(int lbId, int listenPort);

        /// <summary>
        /// Detaches a Load Balancer from a network.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="networkId">ID of an existing network to detach the Load Balancer from</param>
        /// <returns></returns>
        Task<HAction> DetachFromNetwork(int lbId, int networkId);

        /// <summary>
        /// Disable the public interface of a Load Balancer. The Load Balancer will be not accessible from the internet via its public IPs.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <returns></returns>
        Task<HAction> DisablePublicInterface(int lbId);

        /// <summary>
        /// Enable the public interface of a Load Balancer. The Load Balancer will be accessible from the internet via its public IPs.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <returns></returns>
        Task<HAction> EnablePublicInterface(int lbId);

        /// <summary>
        /// Removes a target from a Load Balancer.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction> RemoveTarget(int lbId, RemoveTargetRequest request);

        /// <summary>
        /// Updates a Load Balancer Service.
        /// </summary>
        /// <param name="lbId">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction> UpdateService(int lbId, UpdateServiceRequest request);
    }
}
