using hcloud_api.Exceptions;
using hcloud_api.Models.Objects;
using hcloud_api.Models.Objects.Certificates;
using hcloud_api.Models.Objects.PlacementGroups;
using hcloud_api.Models.Requests.Certificates;
using hcloud_api.Models.Requests.Firewalls;
using hcloud_api.Models.Requests.FloatingIPs;
using hcloud_api.Models.Requests.Images;
using hcloud_api.Models.Requests.LoadBalancers;
using hcloud_api.Models.Requests.Networks;
using hcloud_api.Models.Requests.PlacementGroups;
using hcloud_api.Models.Requests.Servers;
using hcloud_api.Models.Requests.SSHKeys;
using hcloud_api.Models.Requests.Volumes;
using hcloud_api.Models.Responses.Certificates;
using hcloud_api.Models.Responses.Datacenters;
using hcloud_api.Models.Responses.Firewalls;
using hcloud_api.Models.Responses.FloatingIPs;
using hcloud_api.Models.Responses.Images;
using hcloud_api.Models.Responses.ISOs;
using hcloud_api.Models.Responses.LoadBalancers;
using hcloud_api.Models.Responses.Networks;
using hcloud_api.Models.Responses.PlacementGroups;
using hcloud_api.Models.Responses.Servers;
using hcloud_api.Models.Responses.SSHKeys;
using hcloud_api.Models.Responses.Volumes;
using System.Collections.Generic;
using System.Threading.Tasks;
using hcloud_api.Models.Requests.PrimaryIPs;
using hcloud_api.Models.Responses.PrimaryIPs;
// ReSharper disable InconsistentNaming

namespace hcloud_api.Services
{
    /// <summary>
    /// Service for CRUD actions on all Hetzner Cloud objects<br/>
    /// <b>All methods throw an <see cref="hcloud_api.Exceptions.HCloudException"/> if an error field is present in the response from the server</b>
    /// </summary>
    /// <exception cref="hcloud_api.Exceptions.HCloudException"></exception>
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


        /// <summary>
        /// Gets a specific Certificate object.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Certificate> GetCertificate(int id);

        /// <summary>
        /// Returns all Certificate objects.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="type">The response will only contain Certificates matching the type.</param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetCertificatesResponse> GetCertificates(string name = null,
            string labelSelector = null,
            CertificateSortQuery sort = null,
            CertificateType? type = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new Certificate.
        /// <br/>
        /// The default type <b>uploaded</b> allows for uploading your existing <b>certificate</b> and <b>private_key</b> in PEM format.
        /// You have to monitor its expiration date and handle renewal yourself.
        /// <br/>
        /// In contrast, type <b>managed</b> requests a new Certificate from Let's Encrypt for the specified <b>domain_names</b>.
        /// Only domains managed by Hetzner DNS are supported.
        /// We handle renewal and timely alert the project owner via email if problems occur.
        /// <br/>
        /// For type <b>managed</b> Certificates the <b>action</b> key of the response contains the Action that allows for tracking the issuance process.
        /// For type <b>uploaded</b> Certificates the <b>action</b> is always null.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<CreateCertificateResponse> CreateCertificate(CreateServerRequest request);

        /// <summary>
        /// Deletes a Certificate.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteCertificate(int id);

        /// <summary>
        /// Deletes a Certificate.
        /// </summary>
        /// <param name="certificate"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteCertificate(Certificate certificate);

        /// <summary>
        /// Updates the Certificate properties.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Certificate> UpdateCertificate(int id, UpdateCertificateRequest request);

        /// <summary>
        /// Updates the Certificate properties.
        /// </summary>
        /// <param name="certificate"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<Certificate> UpdateCertificate(Certificate certificate);


        /// <summary>
        /// Returns a specific SSH key object.
        /// </summary>
        /// <param name="id">ID of the SSH key</param>
        /// <returns></returns>
        Task<SSHKey> GetSSHKey(int id);

        /// <summary>
        /// Returns all SSH key objects.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="fingerprint">Can be used to filter SSH keys by their fingerprint. The response will only contain the SSH key matching the specified fingerprint.</param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetSSHKeysResponse> GetSSHKeys(string name = null,
            string labelSelector = null,
            string fingerprint = null,
            SSHKeySortQuery sort = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new SSH key with the given <b>name</b> and <b>public_key</b>.
        /// Once an SSH key is created, it can be used in other calls such as creating Servers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<SSHKey> CreateSSHKey(CreateSSHKeyRequest request);

        /// <summary>
        /// Deletes an SSH key. It cannot be used anymore.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteSSHKey(int id);

        /// <summary>
        /// Deletes an SSH key. It cannot be used anymore.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeleteSSHKey(SSHKey key);

        /// <summary>
        /// Updates an SSH key. You can update an SSH key name and an SSH key labels.
        /// <br/>Please note that when updating labels, the SSH key current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<SSHKey> UpdateSSHKey(int id, UpdateSSHKeyRequest request);

        /// <summary>
        /// Updates an SSH key. You can update an SSH key name and an SSH key labels.
        /// <br/>
        /// Please note that when updating labels, the SSH key current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<SSHKey> UpdateSSHKey(SSHKey key);


        /// <summary>
        /// Gets a specific PlacementGroup object.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<PlacementGroup> GetPlacementGroup(int id);

        /// <summary>
        /// Returns all PlacementGroup objects.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="type">The response will only contain PlacementGroups matching the type.</param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<GetPlacementGroupsResponse> GetPlacementGroups(string name = null,
            string labelSelector = null,
            PlacementGroupType? type = null,
            PlacementGroupSortQuery sort = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new PlacementGroup.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<CreatePlacementGroupResponse> CreatePlacementGroup(CreatePlacementGroupRequest request);

        /// <summary>
        /// Deletes a PlacementGroup.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeletePlacementGroup(int id);

        /// <summary>
        /// Deletes a PlacementGroup.
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task DeletePlacementGroup(PlacementGroup group);

        /// <summary>
        /// Updates the PlacementGroup properties.
        /// <br/>
        /// Note that when updating labels, the PlacementGroup’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// <br />
        /// Note: if the PlacementGroup object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<PlacementGroup> UpdatePlacementGroup(int id, UpdatePlacementGroupRequest request);

        /// <summary>
        /// Updates the PlacementGroup properties.
        /// <br/>
        /// Note that when updating labels, the PlacementGroup’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// <br />
        /// Note: if the PlacementGroup object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        /// <exception cref="HCloudException">If an error field is present in the response from the server</exception>
        Task<PlacementGroup> UpdatePlacementGroup(PlacementGroup group);


        /// <summary>
        /// Returns a specific Floating IP object.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <returns></returns>
        Task<FloatingIP> GetFloatingIP(int id);

        /// <summary>
        /// Returns all Floating IP objects.
        /// </summary>
        /// <param name="name">Can be used to filter Floating IPs by their name. The response will only contain the Floating IP matching the specified name.</param>
        /// <param name="labelSelector">Can be used to filter Floating IPs by labels. The response will only contain Floating IPs matching the label selector.</param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        Task<GetFloatingIPsResponse> GetFloatingIPs(string name = null,
            string labelSelector = null,
            FloatingIPSortQuery sort = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new Floating IP assigned to a Server.
        /// <br/>If you want to create a Floating IP that is not bound to a Server, you need to provide the <b>home_location</b> key instead of <b>server</b>.
        /// This can be either the ID or the name of the Location this IP shall be created in.
        /// Note that a Floating IP can be assigned to a Server in any Location later on.
        /// For optimal routing it is advised to use the Floating IP in the same Location it was created in.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateFloatingIPResponse> CreateFloatingIP(CreateFloatingIPRequset request);

        /// <summary>
        /// Deletes a Floating IP. If it is currently assigned to a Server it will automatically get unassigned.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <returns></returns>
        Task DeleteFloatingIP(int id);

        /// <summary>
        /// Deletes a Floating IP. If it is currently assigned to a Server it will automatically get unassigned.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        Task DeleteFloatingIP(FloatingIP ip);

        /// <summary>
        /// Updates the description or labels of a Floating IP.
        /// <br />
        /// Also note that when updating labels, the Floating IP’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="id">ID of the Floating IP</param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FloatingIP> UpdateFloatingIP(int id, UpdateFloatingIPRequest request);

        /// <summary>
        /// Updates the description or labels of a Floating IP.
        /// <br />
        /// Also note that when updating labels, the Floating IP’s current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        Task<FloatingIP> UpdateFloatingIP(FloatingIP ip);


        /// <summary>
        /// Returns a specific Primary IP object.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        Task<PrimaryIP> GetPrimaryIP(int id);

        /// <summary>
        /// Returns all Primary IP objects.
        /// </summary>
        /// <param name="name">Can be used to filter resources by their name. The response will only contain the resources matching the specified name</param>
        /// <param name="labelSelector">Can be used to filter resources by labels. The response will only contain resources matching the label selector.</param>
        /// <param name="ip"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>
        Task<GetPrimaryIPsResponse> GetPrimaryIPs(string name = null,
            string labelSelector = null,
            string ip = null,
            PrimaryIPSortQuery sort = null,
            int? page = null,
            int? perPage = null);

        /// <summary>
        /// Creates a new Primary IP, optionally assigned to a Server.<br/>
        /// If you want to create a Primary IP that is not assigned to a Server, you need to provide the <b><see cref="CreatePrimaryIPRequest.Datacenter"/></b> key instead of <b><see cref="CreatePrimaryIPRequest.AssigneeId"/></b>.
        /// This can be either the ID or the name of the Datacenter this Primary IP shall be created in.<br/>
        /// Note that a Primary IP can only be assigned to a Server in the same Datacenter later on.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreatePrimaryIPResponse> CreatePrimaryIP(CreatePrimaryIPRequest request);

        /// <summary>
        /// Deletes a Primary IP. <br/>
        /// The Primary IP may be assigned to a Server. In this case it is unassigned automatically. The Server must be powered off (status <b>off</b>) in order for this operation to succeed.
        /// </summary>
        /// <param name="id">ID of the resource</param>
        /// <returns></returns>
        Task DeletePrimaryIP(int id);

        /// <summary>
        /// Updates the Primary IP.<br/>
        /// Note that when updating labels, the Primary IP's current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.<br/>
        /// If the Primary IP object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PrimaryIP> UpdatePrimaryIP(int id, UpdatePrimaryIPRequest request);

        /// <summary>
        /// Updates the Primary IP.<br/>
        /// Note that when updating labels, the Primary IP's current set of labels will be replaced with the labels provided in the request body.
        /// So, for example, if you want to add a new label, you have to provide all existing labels plus the new label in the request body.<br/>
        /// If the Primary IP object changes during the request, the response will be a “conflict” error.
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        Task<PrimaryIP> UpdatePrimaryIP(PrimaryIP ip);
    }
}
