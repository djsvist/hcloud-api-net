using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Responses.Servers;
using System.Threading.Tasks;

namespace hcloud_api.Services.Interfaces
{
    public interface IServerService
    {
        Task<Server> GetServer(int id);

        Task<CreateServerResponse> Create(CreateServerRequest template);

        Task<HAction> Delete(Server server);

        Task<HAction> Delete(int id);

        Task<Server> Update(Server server);

        Task<Server> Update(int id, UpdateServerRequest request);
    }
}
