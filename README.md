# hcloud-api-net
A .net library for the Hetzner Cloud API

## Warning
__The package is under development__

At the moment, all CRUD operations (where possible) are implemented.

Actions implemented for the following objects:

`Networks`
`Certificates`
`Servers`
`Volumes`
`LoadBalancers`
`Floating IPs`
`Firewalls`
`Images`

## Installation

```C#
public void ConfigureServices(IServiceCollection services)
{
   services.UseHCloudAPI("your_hcloud_token");
}
```

## Usage

CRUD action placed in `IHCloudService` interface.

You can use parameter object, id or name on creating request

```C#
using hcloud_api.Services;
using hcloud_api.Services.Actions;

private readonly IHCloudService service;

private readonly IServerActionsService serverActions;
private readonly ILoadBalancerActionsService lbActions;
private readonly INetworkActionsService networkActions;
private readonly ISertificateActionsService sertificateActions;
private readonly IVolumeActionsService volumeActions;
private readonly IFirewallActionsService firewallActions;
private readonly IFloatingIPActionsService fIpActions;
private readonly IImageActionsService imageActions;

var serverTypes = await service.GetServerTypes(name: "cx11");

var locations = await service.GetLocations(name: "nbg1");

var request = new CreateServerRequest()
{
    Name = "test-server",
    ServerType = serverTypes.First(),
    ImageName = "ubuntu-20.04",
    LocationId = locations.First().Id
};

var response = await service.CreateServer(request);
var server = response.Server;

var action = await serverActions.PowerOn(server.Id);
```
All methods throw an `hcloud_api.Exceptions.HCloudException` if an error field is present in the response from the server
