using System.Net;
using System.Net.Sockets;
using System.Text;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.IRC.Networking.Sockets;

public class SocketClient : ISocketClient
{
    private readonly ILogger<SocketClient> _logger;
    private readonly IOptions<SocketOptions> _options;

    public SocketClient(IOptions<SocketOptions> options, ILogger<SocketClient> logger)
    {
        _options = options;
        _logger = logger;
    }

    public async Task SendAsync(string message, CancellationToken cancellationToken)
    {
        try
        {
            // _logger.LogDebug("Sending message: {Message}", message);;

            using var socket = new Socket(AddressFamily.InterNetwork, _options.Value.Type, _options.Value.Protocol);
            await socket.ConnectAsync(new IPEndPoint(IPAddress.Loopback, (int)_options.Value.Port), cancellationToken);
            await socket.SendAsync(Encoding.UTF8.GetBytes(message), cancellationToken);
            await socket.DisconnectAsync(false, cancellationToken);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error sending message:  {Message}, With exception message: {ExceptionMessage}", message, e.Message);
        }
    }

    public void Dispose() => _logger.LogDebug("Disposing {ClassName}", nameof(SocketClient));
}