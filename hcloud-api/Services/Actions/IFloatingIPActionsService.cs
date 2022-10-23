using hcloud_api.Models.Objects;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Floating ip actions
    /// </summary>
    public interface IFloatingIPActionsService : IActionsService
    {
        /// <summary>
        /// Assigns a Floating IP to a Server.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <param name="serverId">ID of the Server the Floating IP shall be assigned to</param>
        /// <returns></returns>
        Task<HAction> Assign(int id, int serverId);

        /// <summary>
        /// Changes the hostname that will appear when getting the hostname belonging to this Floating IP.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <param name="ip">IP address for which to set the reverse DNS entry</param>
        /// <param name="dnsPtr">Hostname to set as a reverse DNS PTR entry, will reset to original default value if <b>null</b></param>
        /// <returns></returns>
        Task<HAction> ChangeDNSPointer(int id, string ip, string dnsPtr);

        /// <summary>
        /// Changes the protection configuration of the Floating IP.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delete">If true, prevents the Floating IP from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int id, bool delete);

        /// <summary>
        /// Unassigns a Floating IP, resulting in it being unreachable. You may assign it to a Server again at a later time.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <returns></returns>
        Task<HAction> Unassign(int id);
    }
}
