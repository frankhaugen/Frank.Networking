using Microsoft.Extensions.Logging;

namespace Frank.Networking;

public class SocketConnectionDataReceivedHandler : ISocketConnectionDataReceivedHandler
{
    private readonly ILogger<SocketConnectionDataReceivedHandler> _logger;
    
    public SocketConnectionDataReceivedHandler(ILogger<SocketConnectionDataReceivedHandler> logger)
    {
        _logger = logger;
    }
    
    public void OnDataReceived(object sender, SocketDataReceivedEventArgs e)
    {
        _logger.LogInformation("Data received from client {RemoteEndPoint}: {Data}", e.RemoteEndPoint, e.Data);
    }
}