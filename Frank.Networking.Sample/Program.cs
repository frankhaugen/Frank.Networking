using System.Net;

using Frank.Networking.Sample;
using Frank.Networking.Common;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((context, builder) =>
    {
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