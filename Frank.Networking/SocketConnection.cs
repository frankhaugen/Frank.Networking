using System.Net.Sockets;

using Microsoft.Extensions.Options;

namespace Frank.Networking;

public class SocketConnection : ISocketConnection
{
    private readonly IOptions<SocketConnectionOptions> _options;

    public SocketConnection(SocketConnectionOptions options) => _options = Options.Create(options);

    public SocketConnection(IOptions<SocketConnectionOptions> options) => _options = options;
    
    public async Task SendAsync(byte[] data)
    {
        using var socket = _options.Value.ToSocket();
        await socket.ConnectAsync(_options.Value.ToIPEndpoint());
        await socket.SendAsync(data, SocketFlags.None, CancellationToken.None);
    }

    public async Task<byte[]> ReceiveAsync()
    {
        using var socket = _options.Value.ToSocket();
        await socket.ConnectAsync(_options.Value.ToIPEndpoint());
        var data = new byte[1024];
        await socket.ReceiveAsync(data);
        return data;
    }
}