using hcloud_api.Exceptions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Firewalls;
using hcloud_api.Models.Requests.Images;
using hcloud_api.Models.Requests.LoadBalancers;
using hcloud_api.Models.Requests.Networks;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Requests.Volumes;
using hcloud_api.Models.Responses.Datacenters;
using hcloud_api.Models.Responses.Firewalls;
using hcloud_api.Models.Responses.Images;
using hcloud_api.Models.Responses.ISOs;
using hcloud_api.Models.Responses.LoadBalancers;
using hcloud_api.Models.Responses.Networks;
using hcloud_api.Models.Responses.Servers;
using hcloud_api.Models.Responses.Volumes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hcloud_api.Services
{
    public interface IHCloudService
    {
        /// <summary>
        /// Returns a specific Location object.
        /// </summary>
        /// <param name="id">ID of Location</param>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        /// <returns></returns>
        Task<Location> GetLocation(int id);

        /// <summary>
        /// Returns all Location objects.
        /// </summary>
        /// <param name="name">Can be used to filter Locations by their name. The response will only contain the Location matching the specified name.</param>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        /// <returns></returns>
        Task<IEnumerable<Location>> GetLocations(string name = null);


        /// <summary>
        /// Returns a specific ISO object.
        /// </summary>
        /// <param name="id">ID of the ISO</param>
        /// <returns></returns>
        Task<ISO> GetISO(int id);

        /// <summary>
        /// Returns all available ISO objects.
        /// </summary>
        /// <param name="name">Can be used to filter ISOs by their name. The response will only contain the ISO matching the specified name.</param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        /// <returns></returns>
        Task<ISOsResponse> GetISOs(string name = null, int? page = null, int? perPage = null);


        /// <summary>
        /// Gets a specific Server type object.
        /// </summary>
        /// <param name="id">ID of Server Type</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<ServerType> GetServerType(int id);

        /// <summary>
        /// Gets all Server type objects.
        /// </summary>
        /// <param name="name">Can be used to filter Server types by their name. The response will only contain the Server type matching the specified name.</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<IEnumerable<ServerType>> GetServerTypes(string name = null);

        /// <summary>
        /// Returns a specific Datacenter object.
        /// </summary>
        /// <param name="id">ID of Datacenter</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Datacenter> GetDatacenter(int id);

        /// <summary>
        /// Returns all Datacenter objects.
        /// </summary>
        /// <param name="name">Can be used to filter Datacenters by their name. The response will only contain the Datacenter matching the specified name. When the name does not match the Datacenter name format, an invalid_input error is returned.</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<DatacentersResponse> GetDatacenters(string name = null);


        /// <summary>
        /// Gets a specific Load Balancer type object.
        /// </summary>
        /// <param name="id">ID of Load Balancer type</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<LoadBalancerType> GetLoadBalancerType(int id);

        /// <summary>
        /// Can be used to filter Load Balancer types by their name. 
        /// The response will only contain the Load Balancer type matching the specified name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<IEnumerable<LoadBalancerType>> GetLoadBalancerTypes(string name = null);


        /// <summary>
        /// Gets a specific Load Balancer object.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<LoadBalancer> GetLoadBalancer(int id);

        /// <summary>
        /// Gets all existing Load Balancers that you have available.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelectors">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetLoadBalancersResponse> GetLoadBalancers(string name = null, string labelSelectors = null, LoadBalancerSortQuery sort = null, int? page = null, int? perPage = null);

        /// <summary>
        /// Creates a Load Balancer.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Deletes a Load Balancer.
        /// </summary>
        /// <param name="loadBalancer"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteLoadBalancer(LoadBalancer loadBalancer);

        /// <summary>
        /// Deletes a Load Balancer.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteLoadBalancer(int id);

        /// <summary>
        /// Updates a Load Balancer. You can update a Load Balancer’s name and a Load Balancer’s labels.
        /// </summary>
        /// <param name="loadBalancer"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<LoadBalancer> UpdateLoadBalancer(LoadBalancer loadBalancer);

        /// <summary>
        /// Updates a Load Balancer. You can update a Load Balancer’s name and a Load Balancer’s labels.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<LoadBalancer> UpdateLoadBalancer(int id, UpdateLoadBalancerRequest request);


        /// <summary>
        /// Returns a specific Server object. The Server must exist inside the Project
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Server> GetServer(int id);

        /// <summary>
        /// Returns all existing Server objects
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="status">The response will only contain Server matching the status</param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetServersResponse> GetServers(string name = null, string labelSelector = null, ServerSortQuery sort = null, ServerStatusQuery status = null, int? page = null, int? perPage = null);

        /// <summary>
        /// Creates a new Server. Returns preliminary information about the Server as well as an Action that covers progress of creation.
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<CreateServerResponse> CreateServer(CreateServerRequest template);

        /// <summary>
        /// Deletes a Server. This immediately removes the Server from your account, and it is no longer accessible.
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<HAction> DeleteServer(Server server);


        /// <summary>
        /// Deletes a Server. This immediately removes the Server from your account, and it is no longer accessible.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<HAction> DeleteServer(int id);

        /// <summary>
        /// Updates a Server. You can update a Server’s name and a Server’s labels.
        /// Please note that Server names must be unique per Project and valid hostnames as per RFC 1123 (i.e. may only contain letters, digits, periods, and dashes). 
        /// Also note that when updating labels, the Server’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Server> UpdateServer(Server server);

        /// <summary>
        /// Updates a Server. You can update a Server’s name and a Server’s labels.
        /// Please note that Server names must be unique per Project and valid hostnames as per RFC 1123 (i.e. may only contain letters, digits, periods, and dashes). 
        /// Also note that when updating labels, the Server’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Server> UpdateServer(int id, UpdateServerRequest request);


        /// <summary>
        /// Returns a specific Image object.
        /// </summary>
        /// <param name="id">ID of the Image</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Image> GetImage(int id);

        /// <summary>
        /// Returns all Image objects. You can select specific Image types only and sort the results by using parameters.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="type"></param>
        /// <param name="status">The response will only contain Images matching the status.</param>
        /// <param name="boundTo">Server ID linked to the Image. Only available for Images of type <b>backup</b></param>
        /// <param name="includeDeprecated"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetImagesResponse> GetImages(string name = null, 
            string labelSelector = null, 
            ImageSortQuery sort = null, 
            ImageTypeQuery type = null, 
            ImageStatusQuery status = null, 
            string boundTo = null,
            bool? includeDeprecated = null,
            int? page = null, 
            int? perPage = null);

        /// <summary>
        /// Deletes an Image. Only Images of type <b>snapshot</b> and <b>backup</b> can be deleted.
        /// </summary>
        /// <param name="id">ID of the Image</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Image> DeleteImage(int id);

        /// <summary>
        /// Deletes an Image. Only Images of type <b>snapshot</b> and <b>backup</b> can be deleted.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Image> DeleteImage(Image image);

        /// <summary>
        /// Updates the Image. You may change the description, convert a Backup Image to a Snapshot Image or change the Image labels. Only Images of type <b>snapshot</b> and <b>backup</b> can be updated.
        /// </summary>
        /// <param name="id">ID of the Image</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Image> UpdateImage(int id, UpdateImageRequest request);

        /// <summary>
        /// Updates the Image. You may change the description, convert a Backup Image to a Snapshot Image or change the Image labels. Only Images of type <b>snapshot</b> and <b>backup</b> can be updated.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Image> UpdateImage(Image image);


        /// <summary>
        /// Gets a specific network object.
        /// </summary>
        /// <param name="id">ID of the network</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Network> GetNetwork(int id);

        /// <summary>
        /// Gets all existing networks that you have available.
        /// </summary>
        /// <param name="name">Can be used to filter networks by their name. The response will only contain the networks matching the specified name.</param>
        /// <param name="labelSelector">Can be used to filter networks by labels. The response will only contain networks with a matching label selector pattern.</param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetNetworksResponse> GetNetworks(string name = null,
            string labelSelector = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a network with the specified <b>ip_range</b>.
        /// <br>You may specify one or more <b>subnets</b>.You can also add more Subnets later by using the add subnet action.If you do not specify an ip_range in the subnet we will automatically pick the first available /24 range for you.</br>
        /// <br>You may specify one or more routes in <b>routes</b>.You can also add more routes later by using the add route action.</br>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Network> CreateNetwork(CreateNetworkRequest request);

        /// <summary>
        /// Deletes a network. If there are Servers attached they will be detached in the background.
        /// </summary>
        /// <param name="id">ID of the network</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteNetwork(int id);

        /// <summary>
        /// Deletes a network. If there are Servers attached they will be detached in the background.
        /// </summary>
        /// <param name="network"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteNetwork(Network network);

        /// <summary>
        /// Updates the network properties.
        /// </summary>
        /// <param name="id">ID of the network</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Network> UpdateNetwork(int id, UpdateNetworkRequest request);
        /// <summary>
        /// Updates the network properties.
        /// </summary>
        /// <param name="network"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Network> UpdateNetwork(Network network);


        /// <summary>
        /// Gets a specific Firewall object.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Firewall> GetFirewall(int id);

        /// <summary>
        /// Returns all Firewall objects.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetFirewallsResponse> GetFirewalls(string name = null,
            string labelSelector = null,
            FirewallSortQuery sort = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new Firewall.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<CreateFirewallResponse> CreateFirewall(CreateFirewallRequest request);

        /// <summary>
        /// Deletes a Firewall.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteFirewall(int id);

        /// <summary>
        /// Deletes a Firewall.
        /// </summary>
        /// <param name="firewall"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteFirewall(Firewall firewall);

        /// <summary>
        /// Updates the Firewall.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Firewall> UpdateFirewall(int id, UpdateFirewallRequest request);

        /// <summary>
        /// Updates the Firewall.
        /// </summary>
        /// <param name="firewall"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Firewall> UpdateFirewall(Firewall firewall);


        /// <summary>
        /// Gets a specific Volume object.
        /// </summary>
        /// <param name="id">ID of the Volume</param>
        /// <returns></returns>
        Task<Volume> GetVolume(int id);

        /// <summary>
        /// Gets all existing Volumes that you have available.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="status">The response will only contain Volumes matching the status.</param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        Task<GetVolumesResponse> GetVolumes(string name = null,
            string labelSelector = null,
            VolumeSortQuery sort = null,
            VolumeStatusQuery status = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new Volume attached to a Server. 
        /// If you want to create a Volume that is not attached to a Server, you need to provide the <b>location</b> key instead of <b>server</b>. 
        /// This can be either the ID or the name of the Location this Volume will be created in. Note that a Volume can be attached to a Server only in the same Location as the Volume itself.
        /// <br/><br/>
        /// Specifying the Server during Volume creation will automatically attach the Volume to that Server after it has been initialized. In that case, the <b>next_actions</b> key in the response is an array which contains a single <b>attach_volume</b> action.
        /// <br/><br/>
        /// The minimum Volume size is 10GB and the maximum size is 10TB (10240GB).
        /// <br/><br/>
        /// A volume’s name can consist of alphanumeric characters, dashes, underscores, and dots, but has to start and end with an alphanumeric character. The total length is limited to 64 characters. Volume names must be unique per Project.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateVolumeResponse> CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Deletes a volume. All Volume data is irreversibly destroyed. The Volume must not be attached to a Server and it must not have delete protection enabled.
        /// </summary>
        /// <param name="id">ID of the Volume</param>
        /// <returns></returns>
        Task DeleteVolume(int id);

        /// <summary>
        /// Deletes a volume. All Volume data is irreversibly destroyed. The Volume must not be attached to a Server and it must not have delete protection enabled.
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        Task DeleteVolume(Volume volume);

        /// <summary>
        /// Updates the Volume properties.
        /// </summary>
        /// <param name="id">ID of the Volume to update</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Volume> UpdateVolume(int id, UpdateVolumeRequest request);

        /// <summary>
        /// Updates the Volume properties.
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        Task<Volume> UpdateVolume(Volume volume);
    }
}
