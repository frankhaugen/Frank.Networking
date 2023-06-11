using System.Text;

using Frank.Networking.Server;

public class NetworkDataReceivedHandler : IOnDataReceivedHandler
{
    private readonly ILogger<NetworkDataReceivedHandler> _logger;

    public NetworkDataReceivedHandler(ILogger<NetworkDataReceivedHandler> logger)
    {
        _logger = logger;
    }

    public async Task OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Received data: {Data}", Encoding.UTF8.GetString(data.Span));
    }
}