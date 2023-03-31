using System.Net;
using System.Net.Sockets;

using Frank.Networking;
using Frank.Networking.Application;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSocketListener(new SocketListenerOptions() { IPAddress = IPAddress.Any, Port = 12345, ProtocolType = ProtocolType.Tcp, SocketType = SocketType.Stream, Backlog = 100 });
        
        services.AddSocketSender(new SocketConnectionOptions() {IPAddress = IPAddress.Loopback, Port = 12345, ProtocolType = ProtocolType.Tcp, SocketType = SocketType.Stream,});
        services.AddHostedService<MessageGeneratorService>();
    })
    .Build();

host.Run();