using System.Net.Sockets;
using System.Text;

using Microsoft.Extensions.Logging;

namespace Frank.Networking;

public class SocketClient : ISocketClient
{
    private readonly ILogger<SocketClient> _logger;

    public SocketClient(ILogger<SocketClient> logger)
    {
        _logger = logger;
    }

    public void Send(byte[] data, SocketClientOptions options)
    {
        try
        {
            using var socket = new Socket(options.IPAddress.AddressFamily, options.SocketType, options.ProtocolType);
            socket.Connect(options.ToIPEndpoint());
            socket.Send(data);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending message: {ExceptionMessage}", ex.Message);
        }
    }

    public void SendMessage(string message, SocketClientOptions options)
    {
        var data = Encoding.UTF8.GetBytes(message);
        Send(data, options);
    }
}