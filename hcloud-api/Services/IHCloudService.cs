using hcloud_api.Models.Objects;
using hcloud_api.Models.Requests.Images;
using hcloud_api.Models.Requests.LoadBalancers;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Responses.Datacenters;
using hcloud_api.Models.Responses.Images;
using hcloud_api.Models.Responses.ISOs;
using hcloud_api.Models.Responses.LoadBalancers;
using hcloud_api.Models.Responses.Servers;
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
        /// <returns></returns>
        Task<Location> GetLocation(int id);

        /// <summary>
        /// Returns all Location objects.
        /// </summary>
        /// <param name="name">Can be used to filter Locations by their name. The response will only contain the Location matching the specified name.</param>
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
        /// <returns></returns>
        Task<ISOsResponse> GetISOs(string name = null, int? page = null, int? perPage = null);


        /// <summary>
        /// Gets a specific Server type object.
        /// </summary>
        /// <param name="id">ID of Server Type</param>
        /// <returns></returns>
        Task<ServerType> GetServerType(int id);

        /// <summary>
        /// Gets all Server type objects.
        /// </summary>
        /// <param name="name">Can be used to filter Server types by their name. The response will only contain the Server type matching the specified name.</param>
        /// <returns></returns>
        Task<IEnumerable<ServerType>> GetServerTypes(string name = null);

        /// <summary>
        /// Returns a specific Datacenter object.
        /// </summary>
        /// <param name="id">ID of Datacenter</param>
        /// <returns></returns>
        Task<Datacenter> GetDatacenter(int id);

        /// <summary>
        /// Returns all Datacenter objects.
        /// </summary>
        /// <param name="name">Can be used to filter Datacenters by their name. The response will only contain the Datacenter matching the specified name. When the name does not match the Datacenter name format, an invalid_input error is returned.</param>
        /// <returns></returns>
        Task<DatacentersResponse> GetDatacenters(string name = null);


        /// <summary>
        /// Gets a specific Load Balancer type object.
        /// </summary>
        /// <param name="id">ID of Load Balancer type</param>
        /// <returns></returns>
        Task<LoadBalancerType> GetLoadBalancerType(int id);

        /// <summary>
        /// Can be used to filter Load Balancer types by their name. 
        /// The response will only contain the Load Balancer type matching the specified name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<LoadBalancerType>> GetLoadBalancerTypes(string name = null);


        /// <summary>
        /// Gets a specific Load Balancer object.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <returns></returns>
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
        Task<GetLoadBalancersResponse> GetLoadBalancers(string name = null, string labelSelectors = null, LoadBalancerSortQuery sort = null, int? page = null, int? perPage = null);

        /// <summary>
        /// Creates a Load Balancer.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateLoadBalancerResponse> CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Deletes a Load Balancer.
        /// </summary>
        /// <param name="loadBalancer"></param>
        /// <returns></returns>
        Task DeleteLoadBalancer(LoadBalancer loadBalancer);

        /// <summary>
        /// Deletes a Load Balancer.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <returns></returns>
        Task DeleteLoadBalancer(int id);

        /// <summary>
        /// Updates a Load Balancer. You can update a Load Balancer’s name and a Load Balancer’s labels.
        /// </summary>
        /// <param name="loadBalancer"></param>
        /// <returns></returns>
        Task<LoadBalancer> UpdateLoadBalancer(LoadBalancer loadBalancer);

        /// <summary>
        /// Updates a Load Balancer. You can update a Load Balancer’s name and a Load Balancer’s labels.
        /// </summary>
        /// <param name="id">ID of the Load Balancer</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<LoadBalancer> UpdateLoadBalancer(int id, UpdateLoadBalancerRequest request);


        /// <summary>
        /// Returns a specific Server object. The Server must exist inside the Project
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
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
        Task<GetServersResponse> GetServers(string name = null, string labelSelector = null, ServerSortQuery sort = null, ServerStatusQuery status = null, int? page = null, int? perPage = null);

        /// <summary>
        /// Creates a new Server. Returns preliminary information about the Server as well as an Action that covers progress of creation.
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        Task<CreateServerResponse> CreateServer(CreateServerRequest template);

        /// <summary>
        /// Deletes a Server. This immediately removes the Server from your account, and it is no longer accessible.
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        Task<HAction> DeleteServer(Server server);


        /// <summary>
        /// Deletes a Server. This immediately removes the Server from your account, and it is no longer accessible.
        /// </summary>
        /// <param name="id">ID of the Server</param>
        /// <returns></returns>
        Task<HAction> DeleteServer(int id);

        /// <summary>
        /// Updates a Server. You can update a Server’s name and a Server’s labels.
        /// Please note that Server names must be unique per Project and valid hostnames as per RFC 1123 (i.e. may only contain letters, digits, periods, and dashes). 
        /// Also note that when updating labels, the Server’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
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
        Task<Server> UpdateServer(int id, UpdateServerRequest request);


        /// <summary>
        /// Returns a specific Image object.
        /// </summary>
        /// <param name="id">ID of the Image</param>
        /// <returns></returns>
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
        Task<Image> DeleteImage(int id);

        /// <summary>
        /// Deletes an Image. Only Images of type <b>snapshot</b> and <b>backup</b> can be deleted.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Task<Image> DeleteImage(Image image);

        /// <summary>
        /// Updates the Image. You may change the description, convert a Backup Image to a Snapshot Image or change the Image labels. Only Images of type <b>snapshot</b> and <b>backup</b> can be updated.
        /// </summary>
        /// <param name="id">ID of the Image</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Image> UpdateImage(int id, UpdateImageRequest request);

        /// <summary>
        /// Updates the Image. You may change the description, convert a Backup Image to a Snapshot Image or change the Image labels. Only Images of type <b>snapshot</b> and <b>backup</b> can be updated.
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        Task<Image> UpdateImage(Image image);
    }
}
