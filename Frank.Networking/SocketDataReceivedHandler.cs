using Microsoft.Extensions.Logging;

namespace Frank.Networking;

public class SocketDataReceivedHandler : ISocketDataReceivedHandler
{
    private readonly ILogger<SocketDataReceivedHandler> _logger;
    
    public SocketDataReceivedHandler(ILogger<SocketDataReceivedHandler> logger)
    {
        _logger = logger;
    }
    
    public void OnDataReceived(object sender, SocketDataReceivedEventArgs e)
    {
        _logger.LogInformation("Data received from client {RemoteEndPoint}: {Data}", e.RemoteEndPoint, e.Data);
    }
}