using System.Net.Sockets;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking;

public class SocketListener : BackgroundService
{
    private readonly IOptions<SocketListenerOptions> _options;
    private readonly ILogger<SocketListener> _logger;
    private readonly ISocketDataReceivedHandler _dataReceivedHandler;
    
    public SocketListener(IOptions<SocketListenerOptions> options, ILogger<SocketListener> logger, ISocketDataReceivedHandler dataReceivedHandler)
    {
        _options = options;
        _logger = logger;
        _dataReceivedHandler = dataReceivedHandler;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var listener = new Socket(_options.Value.IPAddress.AddressFamily, _options.Value.SocketType, _options.Value.ProtocolType);
        listener.Bind(_options.Value.ToIPEndpoint()); 
        listener.Listen(_options.Value.Backlog);

        while (!stoppingToken.IsCancellationRequested)
        {
            var client = await listener.AcceptAsync(stoppingToken);
            _ = Task.Run(() => HandleClientAsync(client), stoppingToken);
        }
    }

    private async Task HandleClientAsync(Socket client)
    {
        using (client)
        {
            var buffer = new byte[1024];

            while (client.Connected)
            {
                var bytesRead = await client.ReceiveAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                if (bytesRead > 0)
                {
                    using var stream = new MemoryStream();
                    await stream.ReadAsync(buffer, 0, bytesRead);
                    _dataReceivedHandler.OnDataReceived(this, new SocketDataReceivedEventArgs(client.RemoteEndPoint, stream.ToArray()));
                }
            }
        }
    }
}