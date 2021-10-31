using System.Collections.Generic;
using System.Threading.Tasks;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Actions;
using hcloud_api.Models.Objects.Images;
using hcloud_api.Models.Requests.Actions;
using hcloud_api.Models.Requests.Servers.Actions;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Servers.Actions;

namespace hcloud_api.Services.Actions
{
    public interface IServerActionsService
    {
        /// <summary>
        /// Returns all Action objects for a Server.
        /// You can sort the results by using the sort URI parameter, and filter them with the <b>status</b> parameter.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        Task<GetActionsResponse> GetActions(int serverId,
            ActionSortQuery sort = null,
            ActionStatus? status = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Returns a specific Action object for a Server.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="actionId">ID of the Action</param>
        /// <returns></returns>
        Task<HAction> GetAction(int serverId, int actionId);

        /// <summary>
        /// Adds a Server to a Placement Group.
        /// <br />
        /// <b>Server must be powered off for this command to succeed.</b>
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        Task<HAction> AddToPlacementGroup(int serverId, int groupId);

        /// <summary>
        /// Adds a Server to a Placement Group.
        /// <br />
        /// <b>Server must be powered off for this command to succeed.</b>
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="group"></param>
        /// <returns></returns>
        Task<HAction> AddToPlacementGroup(int serverId, PlacementGroup group);

        /// <summary>
        /// Attaches an ISO to a Server.
        /// <br/>
        /// The Server will immediately see it as a new disk.
        /// An already attached ISO will automatically be detached before the new ISO is attached.
        /// <br />
        /// Servers with attached ISOs have a modified boot order: They will try to boot from the ISO first before falling back to hard disk.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="isoId"></param>
        /// <returns></returns>
        Task<HAction> AttachISO(int serverId, int isoId);

        /// <summary>
        /// Attaches an ISO to a Server.
        /// <br/>
        /// The Server will immediately see it as a new disk.
        /// An already attached ISO will automatically be detached before the new ISO is attached.
        /// <br />
        /// Servers with attached ISOs have a modified boot order: They will try to boot from the ISO first before falling back to hard disk.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="isoName"></param>
        /// <returns></returns>
        Task<HAction> AttachISO(int serverId, string isoName);

        /// <summary>
        /// Attaches an ISO to a Server.
        /// <br/>
        /// The Server will immediately see it as a new disk.
        /// An already attached ISO will automatically be detached before the new ISO is attached.
        /// <br />
        /// Servers with attached ISOs have a modified boot order: They will try to boot from the ISO first before falling back to hard disk.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="iso"></param>
        /// <returns></returns>
        Task<HAction> AttachISO(int serverId, ISO iso);

        /// <summary>
        /// Attaches a Server to a network.
        /// <br />
        /// This will complement the fixed public Server interface by adding an additional ethernet interface to the Server which is connected to the specified network.
        /// <br />
        /// The Server will get an IP auto assigned from a subnet of type <b>server</b> in the same <b>network_zone</b>.
        /// <br />
        /// Using the <b>alias_ips</b> attribute you can also define one or more additional IPs to the Servers.Please note that you will have to configure these IPs by hand on your Server since only the primary IP will be given out by DHCP.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="networkId">ID of an existing network to attach the Server to</param>
        /// <param name="ip">IP to request to be assigned to this Server; if you do not provide this then you will be auto assigned an IP address</param>
        /// <param name="aliasIps">Additional IPs to be assigned to this Server</param>
        /// <returns></returns>
        Task<HAction> AttachToNetwork(int serverId, int networkId, string ip = null, IEnumerable<string> aliasIps = null);

        /// <summary>
        /// Attaches a Server to a network.
        /// <br />
        /// This will complement the fixed public Server interface by adding an additional ethernet interface to the Server which is connected to the specified network.
        /// <br />
        /// The Server will get an IP auto assigned from a subnet of type <b>server</b> in the same <b>network_zone</b>.
        /// <br />
        /// Using the <b>alias_ips</b> attribute you can also define one or more additional IPs to the Servers.Please note that you will have to configure these IPs by hand on your Server since only the primary IP will be given out by DHCP.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="network">Existing network to attach the Server to</param>
        /// <param name="ip">IP to request to be assigned to this Server; if you do not provide this then you will be auto assigned an IP address</param>
        /// <param name="aliasIps">Additional IPs to be assigned to this Server</param>
        /// <returns></returns>
        Task<HAction> AttachToNetwork(int serverId, Network network, string ip = null, IEnumerable<string> aliasIps = null);

        /// <summary>
        /// Changes the alias IPs of an already attached Network.
        /// Note that the existing aliases for the specified Network will be replaced with these provided in the request body.
        /// So if you want to add an alias IP, you have to provide the existing ones from the Network plus the new alias IP in the request body.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="networkId">ID of an existing Network already attached to the Server</param>
        /// <param name="aliasIps">New alias IPs to set for this Server</param>
        /// <returns></returns>
        Task<HAction> ChangeAliasIPs(int serverId, int networkId, IEnumerable<string> aliasIps);

        /// <summary>
        /// Changes the alias IPs of an already attached Network.
        /// Note that the existing aliases for the specified Network will be replaced with these provided in the request body.
        /// So if you want to add an alias IP, you have to provide the existing ones from the Network plus the new alias IP in the request body.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="network">Existing Network already attached to the Server</param>
        /// <param name="aliasIps">New alias IPs to set for this Server</param>
        /// <returns></returns>
        Task<HAction> ChangeAliasIPs(int serverId, Network network, IEnumerable<string> aliasIps);

        /// <summary>
        /// Changes the hostname that will appear when getting the hostname belonging to the primary IPs (IPv4 and IPv6) of this Server.
        /// <br />
        /// Floating IPs assigned to the Server are not affected by this.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="ip">Primary IP address for which the reverse DNS entry should be set</param>
        /// <param name="dnsPointer">Hostname to set as a reverse DNS PTR entry, reset to original value if <b>null</b></param>
        /// <returns></returns>
        Task<HAction> ChangeReverseDNS(int serverId, string ip, string dnsPointer);

        /// <summary>
        /// Changes the protection configuration of the Server.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="protectDelete">If true, prevents the Server from being deleted (currently delete and rebuild attribute needs to have the same value)</param>
        /// <param name="protectRebuild">If true, prevents the Server from being rebuilt (currently delete and rebuild attribute needs to have the same value)</param>
        /// <returns></returns>
        Task<HAction> ChangeProtection(int serverId, bool? protectDelete = null, bool? protectRebuild = null);

        /// <summary>
        /// Changes the type (Cores, RAM and disk sizes) of a Server.
        /// <br />
        /// Server must be powered off for this command to succeed.
        /// <br />
        /// This copies the content of its disk, and starts it again.
        /// <br />
        /// You can only migrate to Server types with the same <b>storage_type</b> and equal or bigger disks.Shrinking disks is not possible as it might destroy data.
        /// <br />
        /// If the disk gets upgraded, the Server type can not be downgraded any more.If you plan to downgrade the Server type, set <b>upgrade_disk</b> to <b>false</b>.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="typeName">name of Server type the Server should migrate to</param>
        /// <param name="upgradeDisk">If false, do not upgrade the disk (this allows downgrading the Server type later)</param>
        /// <returns></returns>
        Task<HAction> ChangeType(int serverId, string typeName, bool upgradeDisk);

        /// <summary>
        /// Creates an Image (snapshot) from a Server by copying the contents of its disks.
        /// <br />
        /// This creates a snapshot of the current state of the disk and copies it into an Image. If the Server is currently running you must make sure that its disk content is consistent. Otherwise, the created Image may not be readable.
        /// <br />
        /// To make sure disk content is consistent, we recommend to shut down the Server prior to creating an Image.
        /// <bt />
        /// You can either create a <b>backup</b> Image that is bound to the Server and therefore will be deleted when the Server is deleted, or you can create an <b>snapshot</b> Image which is completely independent of the Server it was created from and will survive Server deletion. Backup Images are only available when the backup option is enabled for the Server. Snapshot Images are billed on a per GB basis.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="description">Description of the Image, will be auto-generated if not set</param>
        /// <param name="labels">User-defined labels (key-value pairs)</param>
        /// <param name="type">Type of Image to create (default: <b>snapshot</b>)</param>
        /// <returns></returns>
        Task<CreateImageResponse> CreateImage(int serverId, string description = null, Dictionary<string, string> labels = null, ImageType? type = null);

        /// <summary>
        /// Detaches a Server from a network. The interface for this network will vanish.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="networkId">ID of an existing network to detach the Server from</param>
        /// <returns></returns>
        Task<HAction> DetachFromNetwork(int serverId, int networkId);

        /// <summary>
        /// Detaches an ISO from a Server.
        /// <br />
        /// In case no ISO Image is attached to the Server, the status of the returned Action is immediately set to <b>success</b>
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> DetachISO(int serverId);

        /// <summary>
        /// Disables the automatic backup option and deletes all existing Backups for a Server. No more additional charges for backups will be made.
        /// <br />
        /// <b>Caution: This immediately removes all existing backups for the Server!</b>
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> DisableBackups(int serverId);

        /// <summary>
        /// Disables the Hetzner Rescue System for a Server. This makes a Server start from its disks on next reboot.
        /// <br />
        /// Rescue Mode is automatically disabled when you first boot into it or if you do not use it for 60 minutes.
        /// <br />
        /// Disabling rescue mode will not reboot your Server — you will have to do this yourself.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> DisableRescue(int serverId);

        /// <summary>
        /// Enables and configures the automatic daily backup option for the Server. Enabling automatic backups will increase the price of the Server by 20%. In return, you will get seven slots where Images of type backup can be stored.
        /// <br />
        /// Backups are automatically created daily.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> EnableBackups(int serverId);

        /// <summary>
        /// Enable the Hetzner Rescue System for this Server. The next time a Server with enabled rescue mode boots it will start a special minimal Linux distribution designed for repair and reinstall.
        /// <br />
        /// In case a Server cannot boot on its own you can use this to access a Server’s disks.
        /// <br />
        /// Rescue Mode is automatically disabled when you first boot into it or if you do not use it for 60 minutes.
        /// <br />
        /// Enabling rescue mode will not reboot your Server — you will have to do this yourself.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <param name="sshKeys">Array of SSH key IDs which should be injected into the rescue system. Only available for types: <b>linux64</b> and <b>linux32</b></param>
        /// <param name="type">Type of rescue system to boot (default: <b>linux64</b>)</param>
        /// <returns></returns>
        Task<EnableRescueResponse> EnableRescue(int serverId, IEnumerable<int> sshKeys = null, RescueType? type = null);

        /// <summary>
        /// Cuts power to the Server.
        /// <br />
        /// This forcefully stops it without giving the Server operating system time to gracefully stop.
        /// May lead to data loss, equivalent to pulling the power cord. Power off should only be used when shutdown does not work.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> PowerOff(int id);

        /// <summary>
        /// Starts a Server by turning its power on.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> PowerOn(int id);

        /// <summary>
        /// Reboots a Server gracefully by sending an ACPI request.
        /// <br />
        /// The Server operating system must support ACPI and react to the request, otherwise the Server will not reboot.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> Reboot(int id);

        /// <summary>
        /// Rebuilds a Server overwriting its disk with the content of an Image, thereby destroying all data on the target Server
        /// <br />
        /// The Image can either be one you have created earlier(<b>backup</b> or <b>snapshot</b> Image) or it can be a completely fresh <b>system</b> Image provided by us.
        /// <br />
        /// Your Server will automatically be powered off before the rebuild command executes.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <param name="imageName">Name of Image to rebuilt from. Passing a name only works for <b>system</b> Images since the other Image types do not have a name set.</param>
        /// <returns></returns>
        Task<RebuildServerResponse> Rebuild(int id, string imageName);

        /// <summary>
        /// Removes a Server from a Placement Group.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> RemoveFromPlacementGroup(int serverId);

        /// <summary>
        /// Requests credentials for remote access via VNC over websocket to keyboard, monitor, and mouse for a Server.
        /// The provided URL is valid for 1 minute, after this period a new url needs to be created to connect to the Server.
        /// How long the connection is open after the initial connect is not subject to this timeout.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<RequestConsoleResponse> RequestConsole(int serverId);

        /// <summary>
        /// Cuts power to a Server and starts it again.
        /// <br />
        /// This forcefully stops it without giving the Server operating system time to gracefully stop.
        /// This may lead to data loss, it’s equivalent to pulling the power cord and plugging it in again.
        /// Reset should only be used when reboot does not work.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> Reset(int id);

        /// <summary>
        /// Resets the root password. Only works for Linux systems that are running the qemu guest agent. Server must be powered on (state on) in order for this operation to succeed.
        /// <br />
        /// This will generate a new password for this Server and return it.
        /// <br />
        /// If this does not succeed you can use the rescue system to netboot the Server and manually change your Server password by hand.
        /// </summary>
        /// <param name="serverId">ID of the Server</param>
        /// <returns></returns>
        Task<ResetPasswordResponse> ResetPassword(int serverId);

        /// <summary>
        /// Shuts down a Server gracefully by sending an ACPI shutdown request.
        /// <br />
        /// The Server operating system must support ACPI and react to the request, otherwise the Server will not shut down.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> Shutdown(int id);
    }
}
