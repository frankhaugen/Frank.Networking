using System.Net;
using System.Net.Sockets;

namespace Frank.Networking.Common;

public static class NetworkConnectionFactory
{
    public static Socket CreateSocket(NetworkConfiguration configuration) => new(configuration.SocketType, configuration.ProtocolType);

    public static Socket CreateBoundSocket(NetworkConfiguration configuration)
    {
        var socket = CreateSocket(configuration);
        socket.Bind(new IPEndPoint(configuration.IPAddress, configuration.Port));
        return socket;
    }
    
    public static Socket CreateListeningBoundSocket(NetworkConfiguration configuration)
    {
        var socket = CreateBoundSocket(configuration);
        socket.Listen();
        return socket;
    }
    
    public static async Task<Socket> CreateConnectedSocketAsync(NetworkConfiguration configuration, CancellationToken cancellationToken)
    {
        var socket = CreateSocket(configuration);
        await socket.ConnectAsync(new IPEndPoint(configuration.IPAddress, configuration.Port), cancellationToken);
        return socket;
    }
    
    public static async Task<NetworkStream> CreateConnectedNetworkStreamAsync(NetworkConfiguration configuration, CancellationToken cancellationToken)
    {
        var socket = await CreateConnectedSocketAsync(configuration, cancellationToken);
        return new NetworkStream(socket);
    }
}