using System.Net.Sockets;

using Microsoft.Extensions.Options;

namespace Frank.Networking;

public class SocketFactory : ISocketFactory
{
    private readonly IOptions<SocketOptions> _options;

    public SocketFactory(IOptions<SocketOptions> options) => _options = options;

    public Socket CreateSocket(SocketOptions? options = null) => options is null ? _options.Value.ToSocket() : options.ToSocket();
}