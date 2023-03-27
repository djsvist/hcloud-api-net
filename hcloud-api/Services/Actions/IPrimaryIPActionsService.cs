using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.PrimaryIPs;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Primary ip actions
    /// </summary>
    public interface IPrimaryIPActionsService : IActionsService
    {
        /// <summary>
        /// Assigns a Primary IP to a Server.<br/>
        /// A Server can only have one Primary IP of type ipv4 and one of type ipv6 assigned. If you need more IPs use Floating IPs.<br/>
        /// The Server must be powered off (status <b>off</b>) in order for this operation to succeed.
        /// </summary>
        /// <param name="ipId">ID of the Primary IP</param>
        /// <param name="assigneeId">ID of a resource</param>
        /// <param name="assigneeType">Type of resource assigning the Primary IP to</param>
        /// <returns></returns>
        Task<HAction> AssignTo(int ipId, int assigneeId, AssigneeType assigneeType);

        /// <summary>
        /// Changes the hostname that will appear when getting the hostname belonging to this Primary IP.
        /// </summary>
        /// <param name="ipId">ID of the Primary IP</param>
        /// <param name="ip">IP address for which to set the reverse DNS entry</param>
        /// <param name="dnsPtr">Hostname to set as a reverse DNS PTR entry, will reset to original default value if null</param>
        /// <returns></returns>
        Task<HAction> ChangeDNSPointer(int ipId, string ip, string dnsPtr);

        /// <summary>
        /// Changes the protection configuration of a Primary IP.<br/>
        /// A Primary IP can only be delete protected if its <b>AutoDelete</b> property is set to <b>false</b>.
        /// </summary>
        /// <param name="ipId">ID of the Primary IP</param>
        /// <param name="delete"></param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int ipId, bool delete);

        /// <summary>
        /// Unassigns a Primary IP from a Server.<br/>
        /// The Server must be powered off (status <b>off</b>) in order for this operation to succeed.<br/>
        /// Note that only Servers that have at least one network interface (public or private) attached can be powered on.
        /// </summary>
        /// <param name="ipId">ID of the Primary IP</param>
        /// <returns></returns>
        Task<HAction> Unassign(int ipId);
    }
}
