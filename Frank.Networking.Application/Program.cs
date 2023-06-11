using System.Net;
using System.Text.Json;

using Frank.Networking.Application;
using Frank.Networking.Common;

using Microsoft.Extensions.Logging.Console;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((context, builder) =>
    {
        builder.ClearProviders();
        builder.AddConsole();
    })
    .ConfigureServices(services =>
    {
        services.AddNetworkServer<NetworkDataReceivedHandler>(config =>
        {
        });
        
        services.AddNetworkClient(config =>
        {
            config.IPAddress = IPAddress.Loopback;
        });
        
        services.AddHostedService<Worker>();
    })
    .Build();
 
host.Run();