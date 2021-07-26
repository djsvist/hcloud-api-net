# hcloud-api-net
A .net library for the Hetzner Cloud API

## Warning
__The package is under development__

At the moment, only CRUD operations (where possible) are implemented for the following objects:

`ISOs`
`Datacenters`
`Servers`
`Server types`
`Networks`
`Images`
`LoadBalancers`
`LoadBalancer Types`
`Locations`

## Installation

```C#
public void ConfigureServices(IServiceCollection services)
{
   services.UseHCloudAPI("your_hcloud_token");
}
```

## Usage

You can use parameter object, id or name on creating request

```C#
using hcloud_api.Services;

private readonly IHCloudService service;

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
```
All methods throw an `hcloud_api.Exceptions.HCloudException` if an error field is present in the response from the server
