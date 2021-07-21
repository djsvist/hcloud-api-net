using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Servers;
using hcloud_api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace hcloud_api.Services.Impl
{
    public class ServerService : IServerService
    {
        private readonly HttpClient client;

        public ServerService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<CreateServerResponse> Create(CreateServerRequest template)
        {
            return await client.PostJsonAsync<CreateServerResponse>(Path, template);
        }

        public async Task<HAction> Delete(Server server)
        {
            return await Delete(server.Id);
        }

        public async Task<HAction> Delete(int id)
        {
            var result = await client.DeleteJsonAsync<ActionResponse>($"{Path}/{id}");
            return result.Action;
        }

        public async Task<Server> GetServer(int id)
        {
            var response = await client.GetJsonAsync<ServerResponse>($"{Path}/{id}");
            return response.Server;
        }

        public async Task<Server> Update(Server server)
        {
            return await Update(server.Id, new UpdateServerRequest()
            {
                Name = server.Name,
                Labels = server.Labels
            });
        }

        public async Task<Server> Update(int id, UpdateServerRequest request)
        {
            var result = await client.PutJsonAsync<ServerResponse>($"{Path}/{id}", request);
            return result.Server;
        }

        private string Path => "servers";
    }
}
