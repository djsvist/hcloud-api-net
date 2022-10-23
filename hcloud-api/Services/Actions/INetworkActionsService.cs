using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Networks;
using System.Threading.Tasks;

namespace hcloud_api.Services.Actions
{
    /// <summary>
    /// Network actions
    /// </summary>
    public interface INetworkActionsService : IActionsService
    {
        /// <summary>
        /// Adds a route entry to a Network.<br/>
        /// Note: if the Network object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="destination">Destination network or host of this route. Must not overlap with an existing ip_range in any subnets or with any destinations in other routes or with the first IP of the networks ip_range or with 172.31.1.1. Must be one of the private IPv4 ranges of RFC1918.</param>
        /// <param name="gateway">Gateway for the route. Cannot be the first IP of the networks ip_range, an IP behind a vSwitch or 172.31.1.1, as this IP is being used as a gateway for the public network interface of Servers.</param>
        /// <returns></returns>
        Task<HAction> AddRoute(int networkId, string destination, string gateway);

        /// <summary>
        /// Adds a route entry to a Network.
        /// </summary>
        /// <param name="network">Network</param>
        /// <param name="destination">Destination network or host of this route. Must not overlap with an existing ip_range in any subnets or with any destinations in other routes or with the first IP of the networks ip_range or with 172.31.1.1. Must be one of the private IPv4 ranges of RFC1918.</param>
        /// <param name="gateway">Gateway for the route. Cannot be the first IP of the networks ip_range, an IP behind a vSwitch or 172.31.1.1, as this IP is being used as a gateway for the public network interface of Servers.</param>
        /// <returns></returns>
        Task<HAction> AddRoute(Network network, string destination, string gateway);

        /// <summary>
        /// Adds a new subnet object to the Network. If you do not specify an <b>ip_range</b> for the subnet we will automatically pick the first available /24 range for you if possible.
        /// Note: if the parent Network object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="networkZone">Name of Network zone. The Location object contains the <b>network_zone</b> property each Location belongs to.</param>
        /// <param name="type"></param>
        /// <param name="ipRange">Range to allocate IPs from. Must be a Subnet of the ip_range of the parent network object and must not overlap with any other subnets or with any destinations in routes.
        /// If the Subnet is of type vSwitch, it also can not overlap with any gateway in routes. Minimum Network size is /30.
        /// We suggest that you pick a bigger Network with a /24 netmask.</param>
        /// <param name="vSwitchId">ID of the robot vSwitch. Must be supplied if the subnet is of type vswitch.</param>
        /// <returns></returns>
        Task<HAction> AddSubnet(int networkId, string networkZone, SubnetType type, string ipRange = null, int? vSwitchId = null);

        /// <summary>
        /// Changes the IP range of a Network. IP ranges can only be extended and never shrunk. You can only add IPs at the end of an existing IP range.
        /// This means that the IP part of your existing range must stay the same and you can only change its netmask.
        /// <br/>
        /// For example if you have a range <b>10.0.0.0/16</b> you want to extend then your new range must also start with the IP <b>10.0.0.0</b>.
        /// Your CIDR netmask <b>/16</b> may change to a number that is smaller than <b>16</b> thereby increasing the IP range.
        /// So valid entries would be <b>10.0.0.0/15</b>, <b>10.0.0.0/14</b>, <b>10.0.0.0/13</b> and so on.
        /// <br/>
        /// After changing the IP range you will have to adjust the routes on your connected Servers by either rebooting them or manually changing the routes to your private Network interface.
        /// <br/>
        /// Note: if the Network object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="ipRange">The new prefix for the whole Network</param>
        /// <returns></returns>
        Task<HAction> ChangeIpRange(int networkId, string ipRange);

        /// <summary>
        /// Changes the protection configuration of a Network.<br/>
        /// Note: if the Network object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="delete">If true, prevents the Network from being deleted</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int networkId, bool delete);

        /// <summary>
        /// Delete a route entry from a Network.<br/>
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="destination">Destination network or host of this route. Must not overlap with an existing ip_range in any subnets or with any destinations in other routes or with the first IP of the networks ip_range or with 172.31.1.1. Must be one of the private IPv4 ranges of RFC1918.</param>
        /// <param name="gateway">Gateway for the route. Cannot be the first IP of the networks ip_range, an IP behind a vSwitch or 172.31.1.1, as this IP is being used as a gateway for the public network interface of Servers.</param>
        /// <returns></returns>
        Task<HAction> DeleteRoute(int networkId, string destination, string gateway);

        /// <summary>
        /// Deletes a single subnet entry from a Network. You cannot delete subnets which still have Servers attached. If you have Servers attached you first need to detach all Servers that use IPs from this subnet before you can delete the subnet.
        /// </summary>
        /// <param name="networkId">ID of the Network</param>
        /// <param name="ipRange">IP range of subnet to delete</param>
        /// <returns></returns>
        Task<HAction> DeleteSubnet(int networkId, string ipRange);
    }
}
