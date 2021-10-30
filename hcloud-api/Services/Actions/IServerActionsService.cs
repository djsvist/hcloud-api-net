using System.Threading.Tasks;
using hcloud_api.Models.Objects;

namespace hcloud_api.Services.Actions
{
    public interface IServerActionsService
    {
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
        /// Shuts down a Server gracefully by sending an ACPI shutdown request.
        /// <br />
        /// The Server operating system must support ACPI and react to the request, otherwise the Server will not shut down.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> Shutdown(int id);
    }
}
