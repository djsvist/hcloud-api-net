﻿using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.LoadBalancers;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Datacenters;
using hcloud_api.Models.Responses.ISOs;
using hcloud_api.Models.Responses.LoadBalancers;
using hcloud_api.Models.Responses.Locations;
using hcloud_api.Models.Responses.Servers;
using hcloud_api.Models.Responses.ServerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace hcloud_api.Services
{
    public class HCloudService : IHCloudService
    {
        private const string LBPath = "load_balancers";
        private const string DCPath = "datacenters";
        private const string ISOPath = "isos";
        private const string LocationPath = "locations";
        private const string STPath = "server_types";
        private const string ServerPath = "servers";

        private readonly HttpClient client;

        public HCloudService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            return await client.PostJsonAsync<CreateLoadBalancerResponse>(LBPath, request);
        }

        public async Task DeleteLoadBalancer(LoadBalancer loadBalancer)
        {
            await DeleteLoadBalancer(loadBalancer.Id);
        }

        public async Task DeleteLoadBalancer(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(LBPath, id));
        }

        public async Task<Datacenter> GetDatacenter(int id)
        {
            var result = await client.GetJsonAsync<DatacenterResponse>(Append(DCPath, id));
            return result.Datacenter;
        }

        public async Task<DatacentersResponse> GetDatacenters(string name = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);

            return await client.GetJsonAsync<DatacentersResponse>(Append(DCPath, query));
        }

        public async Task<ISO> GetISO(int id)
        {
            var result = await client.GetJsonAsync<ISOResponse>(Append(ISOPath, id));
            return result.ISO;
        }

        public async Task<ISOsResponse> GetISOs(string name = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<ISOsResponse>(Append(ISOPath, query));
        }

        public async Task<LoadBalancer> GetLoadBalancer(int id)
        {
            var result = await client.GetJsonAsync<LoadBalancerResponse>(Append(LBPath, id));
            return result.LoadBalancer;
        }

        public async Task<GetLoadBalancersResponse> GetLoadBalancers(string name = null, string labelSelectors = null, LoadBalancerSortQuery sort = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelectors);
            query.AddNotNull("sort", sort);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetLoadBalancersResponse>(Append(LBPath, query));
        }

        public async Task<Location> GetLocation(int id)
        {
            var result = await client.GetJsonAsync<GetLocationResponse>(Append(LocationPath, id));
            return result.Location;
        }

        public async Task<IEnumerable<Location>> GetLocations(string name = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);

            var result = await client.GetJsonAsync<GetLocationsResponse>(Append(LocationPath, query));
            return result.Locations;
        }

        public async Task<ServerType> GetServerType(int id)
        {
            var result = await client.GetJsonAsync<GetServerTypeResponse>(Append(STPath, id));
            return result.ServerType;
        }

        public async Task<IEnumerable<ServerType>> GetServerTypes(string name = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);

            var result = await client.GetJsonAsync<GetServerTypesResponse>(Append(STPath, query));
            return result.ServerTypes;
        }

        public async Task<LoadBalancer> UpdateLoadBalancer(LoadBalancer loadBalancer)
        {
            return await UpdateLoadBalancer(loadBalancer.Id, new UpdateLoadBalancerRequest
            {
                Name = loadBalancer.Name,
                Labels = loadBalancer.Labels
            });
        }

        public async Task<LoadBalancer> UpdateLoadBalancer(int id, UpdateLoadBalancerRequest request)
        {
            var result = await client.PostJsonAsync<LoadBalancerResponse>(Append(LBPath, id), request);
            return result.LoadBalancer;
        }

        public async Task<CreateServerResponse> CreateServer(CreateServerRequest template)
        {
            return await client.PostJsonAsync<CreateServerResponse>(ServerPath, template);
        }

        public async Task<HAction> DeleteServer(Server server)
        {
            return await DeleteServer(server.Id);
        }

        public async Task<HAction> DeleteServer(int id)
        {
            var result = await client.DeleteJsonAsync<ActionResponse>(Append(ServerPath, id));
            return result.Action;
        }

        public async Task<Server> GetServer(int id)
        {
            var response = await client.GetJsonAsync<ServerResponse>(Append(ServerPath, id));
            return response.Server;
        }

        public async Task<GetServersResponse> GetServers(string name = null, string labelSelectors = null, ServerSortQuery sort = null, ServerStatusQuery status = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelectors);
            query.AddNotNull("sort", sort);
            query.AddNotNull("status", status);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetServersResponse>(Append(ServerPath, query));
        }

        public async Task<Server> UpdateServer(Server server)
        {
            return await UpdateServer(server.Id, new UpdateServerRequest()
            {
                Name = server.Name,
                Labels = server.Labels
            });
        }

        public async Task<Server> UpdateServer(int id, UpdateServerRequest request)
        {
            var result = await client.PutJsonAsync<ServerResponse>(Append(ServerPath, id), request);
            return result.Server;
        }

        private static string Replace(string path, int id) => path.Replace("{id}", id.ToString());

        private static string Append(string path, int id) => path + "/" + id;

        private static string Append(string path, Dictionary<string, object> query)
        {
            if (query == null || query.Count == 0)
                return path;

            return query.Aggregate($"{path}?", (p, pair) =>
            {
                if (!p.EndsWith("?"))
                    p += "&";

                return p + $"{pair.Key}={pair.Value}";
            });
        }
    }
}
