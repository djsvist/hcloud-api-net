using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Firewalls.Actions;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Firewall actions
    /// </summary>
    public interface IFirewallActionsService
    {
        /// <summary>
        /// Applies one Firewall to multiple resources.<br/>
        /// Currently servers (public network interface) and label selectors are supported.
        /// </summary>
        /// <param name="firewallId">ID of the Firewall</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction[]> ApplyToResources(int firewallId, ApplyToResourcesRequest request);

        /// <summary>
        /// Removes one Firewall from multiple resources.<br/>
        /// Currently only Servers (and their public network interfaces) are supported.
        /// </summary>
        /// <param name="firewallId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction[]> RemoveFromResources(int firewallId, RemoveFromResourcesRequest request);

        /// <summary>
        /// Sets the rules of a Firewall<br/>
        /// All existing rules will be overwritten. Pass an empty rules array to remove all rules. The maximum amount of rules that can be defined is 50.
        /// </summary>
        /// <param name="firewallId">ID of the Firewall</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<HAction[]> SetRules(int firewallId, SetRulesRequest request);
    }
}
