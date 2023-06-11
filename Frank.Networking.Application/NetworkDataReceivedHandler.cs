using System.Globalization;
using System.Text;

using Frank.Networking.Server;

public class NetworkDataReceivedHandler : IOnDataReceivedHandler
{
    private readonly ILogger<NetworkDataReceivedHandler> _logger;

    public NetworkDataReceivedHandler(ILogger<NetworkDataReceivedHandler> logger)
    {
        _logger = logger;
    }

    public async Task<ReadOnlyMemory<byte>> OnDataReceivedAsync(ReadOnlyMemory<byte> data, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Received data at server: {Data}", Encoding.UTF8.GetString(data.Span));
        var response = Encoding.UTF8.GetBytes(DateTime.UtcNow.ToString(CultureInfo.InvariantCulture));
        return new ReadOnlyMemory<byte>(response);
    }
}