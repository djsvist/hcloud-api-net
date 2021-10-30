using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using hcloud_api.Extensions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Certificates;
using hcloud_api.Models.Requests.Certificates;
using hcloud_api.Models.Requests.Firewalls;
using hcloud_api.Models.Requests.Images;
using hcloud_api.Models.Requests.LoadBalancers;
using hcloud_api.Models.Requests.Networks;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Requests.SSHKeys;
using hcloud_api.Models.Requests.Volumes;
using hcloud_api.Models.Responses;
using hcloud_api.Models.Responses.Certificates;
using hcloud_api.Models.Responses.Datacenters;
using hcloud_api.Models.Responses.Firewalls;
using hcloud_api.Models.Responses.Images;
using hcloud_api.Models.Responses.ISOs;
using hcloud_api.Models.Responses.LoadBalancers;
using hcloud_api.Models.Responses.LoadBalancerTypes;
using hcloud_api.Models.Responses.Locations;
using hcloud_api.Models.Responses.Networks;
using hcloud_api.Models.Responses.Servers;
using hcloud_api.Models.Responses.ServerTypes;
using hcloud_api.Models.Responses.SSHKeys;
using hcloud_api.Models.Responses.Volumes;

namespace hcloud_api.Services
{
    public class HCloudService : IHCloudService
    {
        private const string LBPath = "load_balancers";
        private const string LBTypePath = "load_balancer_types";
        private const string DCPath = "datacenters";
        private const string ISOPath = "isos";
        private const string LocationPath = "locations";
        private const string STPath = "server_types";
        private const string ServerPath = "servers";
        private const string ImagePath = "images";
        private const string NetworkPath = "networks";
        private const string FirewallPath = "firewalls";
        private const string VolumePath = "volumes";
        private const string CertificatePath = "certificates";
        private const string SSHKeyPath = "ssh_keys";

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

        public async Task<LoadBalancerType> GetLoadBalancerType(int id)
        {
            var result = await client.GetJsonAsync<GetLoadBalancerTypeResponse>(Append(LBTypePath, id));
            return result.LoadBalancerType;
        }

        public async Task<IEnumerable<LoadBalancerType>> GetLoadBalancerTypes(string name = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);

            var result = await client.GetJsonAsync<GetLoadBalancerTypesResponse>(Append(LBTypePath, query));
            return result.LoadBalancerTypes;

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

        public async Task<Image> GetImage(int id)
        {
            var result = await client.GetJsonAsync<ImageResponse>(Append(ImagePath, id));
            return result.Image;
        }

        public async Task<GetImagesResponse> GetImages(string name = null, string labelSelector = null, ImageSortQuery sort = null, ImageTypeQuery type = null, ImageStatusQuery status = null, string boundTo = null, bool? includeDeprecated = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("sort", sort);
            query.AddNotNull("status", status);
            query.AddNotNull("type", type);
            query.AddNotNull("bound_to", boundTo);
            query.AddNotNull("include_deprecated", includeDeprecated);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetImagesResponse>(ImagePath);
        }

        public async Task<Image> DeleteImage(int id)
        {
            var result = await client.DeleteJsonAsync<ImageResponse>(Append(ImagePath, id));
            return result.Image;
        }

        public async Task<Image> DeleteImage(Image image)
        {
            return await DeleteImage(image.Id);
        }

        public async Task<Image> UpdateImage(int id, UpdateImageRequest request)
        {
            var result = await client.PutJsonAsync<ImageResponse>(Append(ImagePath, id), request);
            return result.Image;
        }

        public async Task<Image> UpdateImage(Image image)
        {
            return await UpdateImage(image.Id, new UpdateImageRequest
            {
                Description = image.Description,
                Labels = image.Labels
            });
        }

        public async Task<Network> GetNetwork(int id)
        {
            var result = await client.GetJsonAsync<NetworkResponse>(Append(NetworkPath, id));
            return result.Network;
        }

        public async Task<GetNetworksResponse> GetNetworks(string name = null, string labelSelector = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetNetworksResponse>(Append(NetworkPath, query));
        }

        public async Task<Network> CreateNetwork(CreateNetworkRequest request)
        {
            var result = await client.PostJsonAsync<NetworkResponse>(NetworkPath, request);
            return result.Network;
        }

        public async Task DeleteNetwork(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(NetworkPath, id));
        }

        public async Task DeleteNetwork(Network network)
        {
            await DeleteNetwork(network.Id);
        }

        public async Task<Network> UpdateNetwork(int id, UpdateNetworkRequest request)
        {
            var result = await client.PutJsonAsync<NetworkResponse>(Append(NetworkPath, id), request);
            return result.Network;
        }

        public async Task<Network> UpdateNetwork(Network network)
        {
            return await UpdateNetwork(network.Id, new UpdateNetworkRequest
            {
                Name = network.Name,
                Labels = network.Labels
            });
        }

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

        public async Task<Firewall> GetFirewall(int id)
        {
            var result = await client.GetJsonAsync<FirewallResponse>(Append(FirewallPath, id));
            return result.Firewall;
        }

        public async Task<GetFirewallsResponse> GetFirewalls(string name = null, string labelSelector = null, FirewallSortQuery sort = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("sort", sort);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetFirewallsResponse>(Append(FirewallPath, query));
        }

        public async Task<CreateFirewallResponse> CreateFirewall(CreateFirewallRequest request)
        {
            return await client.PostJsonAsync<CreateFirewallResponse>(FirewallPath, request);
        }

        public async Task DeleteFirewall(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(FirewallPath, id));
        }

        public async Task DeleteFirewall(Firewall firewall)
        {
            await DeleteFirewall(firewall.Id);
        }

        public async Task<Firewall> UpdateFirewall(int id, UpdateFirewallRequest request)
        {
            var result = await client.PutJsonAsync<FirewallResponse>(Append(FirewallPath, id), request);
            return result.Firewall;
        }

        public async Task<Firewall> UpdateFirewall(Firewall firewall)
        {
            return await UpdateFirewall(firewall.Id, new UpdateFirewallRequest
            {
                Labels = firewall.Labels,
                Name = firewall.Name
            });
        }

        public async Task<Volume> GetVolume(int id)
        {
            var result = await client.GetJsonAsync<VolumeResponse>(Append(VolumePath, id));
            return result.Volume;
        }

        public async Task<GetVolumesResponse> GetVolumes(string name = null, string labelSelector = null, VolumeSortQuery sort = null, VolumeStatusQuery status = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("sort", sort);
            query.AddNotNull("status", status);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetVolumesResponse>(Append(VolumePath, query));
        }

        public async Task<CreateVolumeResponse> CreateVolume(CreateVolumeRequest request)
        {
            return await client.PostJsonAsync<CreateVolumeResponse>(VolumePath, request);
        }

        public async Task DeleteVolume(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(VolumePath, id));
        }

        public async Task DeleteVolume(Volume volume)
        {
            await client.DeleteJsonAsync<IResponse>(Append(VolumePath, volume.Id));
        }

        public async Task<Volume> UpdateVolume(int id, UpdateVolumeRequest request)
        {
            var result = await client.PutJsonAsync<VolumeResponse>(Append(VolumePath, id), request);
            return result.Volume;
        }

        public async Task<Volume> UpdateVolume(Volume volume)
        {
            return await UpdateVolume(volume.Id, new UpdateVolumeRequest
            {
                Name = volume.Name,
                Labels = volume.Labels
            });
        }

        public async Task<Certificate> GetCertificate(int id)
        {
            var result = await client.GetJsonAsync<CertificateResponse>(Append(CertificatePath, id));
            return result.Certificate;
        }

        public async Task<GetCertificatesResponse> GetCertificates(string name = null, string labelSelector = null, CertificateSortQuery sort = null, CertificateType? type = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("sort", sort);
            query.AddNotNull("type", type);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetCertificatesResponse>(Append(CertificatePath, query));
        }

        public async Task<CreateCertificateResponse> CreateCertificate(CreateServerRequest request)
        {
            return await client.PostJsonAsync<CreateCertificateResponse>(CertificatePath, request);
        }

        public async Task DeleteCertificate(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(CertificatePath, id));
        }

        public async Task DeleteCertificate(Certificate certificate)
        {
            await DeleteCertificate(certificate.Id);
        }

        public async Task<Certificate> UpdateCertificate(int id, UpdateCertificateRequest request)
        {
            var result = await client.PutJsonAsync<CertificateResponse>(Append(CertificatePath, id), request);
            return result.Certificate;
        }

        public async Task<Certificate> UpdateCertificate(Certificate certificate)
        {
            return await UpdateCertificate(certificate.Id, new UpdateCertificateRequest
            {
                Labels = certificate.Labels,
                Name = certificate.Name
            });
        }

        public async Task<SSHKey> GetSSHKey(int id)
        {
            var result = await client.GetJsonAsync<SSHKeyResponse>(Append(SSHKeyPath, id));
            return result.Key;
        }

        public async Task<GetSSHKeysResponse> GetSSHKeys(string name = null, string labelSelector = null, string fingerprint = null, SSHKeySortQuery sort = null, int? page = null, int? perPage = null)
        {
            var query = new Dictionary<string, object>();
            query.AddNotNull("name", name);
            query.AddNotNull("label_selector", labelSelector);
            query.AddNotNull("sort", sort);
            query.AddNotNull("fingerprint", fingerprint);
            query.AddNotNull("page", page);
            query.AddNotNull("per_page", perPage);

            return await client.GetJsonAsync<GetSSHKeysResponse>(Append(SSHKeyPath, query));
        }

        public async Task<SSHKey> CreateSSHKey(CreateSSHKeyRequest request)
        {
            var result = await client.PostJsonAsync<SSHKeyResponse>(SSHKeyPath, request);
            return result.Key;
        }

        public async Task DeleteSSHKey(int id)
        {
            await client.DeleteJsonAsync<IResponse>(Append(SSHKeyPath, id));
        }

        public async Task DeleteSSHKey(SSHKey key)
        {
            await DeleteSSHKey(key.Id);
        }

        public async Task<SSHKey> UpdateSSHKey(int id, UpdateSSHKeyRequest request)
        {
            var result = await client.PutJsonAsync<SSHKeyResponse>(Append(SSHKeyPath, id), request);
            return result.Key;
        }

        public async Task<SSHKey> UpdateSSHKey(SSHKey key)
        {
            return await UpdateSSHKey(key.Id, new UpdateSSHKeyRequest
            {
                Labels = key.Labels,
                Name = key.Name
            });
        }
    }
}
