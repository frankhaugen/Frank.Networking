using System.Net.Sockets;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public class SocketSender : ISocketSender
{
    private readonly ILogger<SocketSender> _logger;
    private readonly IOptions<SocketSenderOptions> _options;

    public SocketSender(ILogger<SocketSender> logger, IOptions<SocketSenderOptions> options)
    {
        _logger = logger;
        _options = options;
    }

    public async Task SendAsync(byte[] data)
    {
        try
        {
            using var socket = new Socket(_options.Value.IPAddress.AddressFamily, _options.Value.SocketType, _options.Value.ProtocolType);
            await socket.ConnectAsync(_options.Value.ToIPEndpoint());
            await socket.SendAsync(data);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending message: {ExceptionMessage}", ex.Message);
        }
    }
}