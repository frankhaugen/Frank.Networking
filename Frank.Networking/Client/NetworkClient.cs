using System.Net.Sockets;
using System.Text;

using Frank.Networking.Common;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking.Client;

public class NetworkClient : INetworkClient
{
    private readonly ILogger<NetworkClient> _logger;
    private readonly IOptions<NetworkClientConfiguration> _options;
    
    // private NetworkStream? _networkStream;

    public NetworkClient(IOptions<NetworkClientConfiguration> options, ILogger<NetworkClient> logger)
    {
        _options = options;
        _logger = logger;
    }

    public async Task SendAsync(ReadOnlyMemory<Byte> data, CancellationToken cancellationToken)
    {
        await using var networkStream = await NetworkConnectionFactory.CreateConnectedNetworkStreamAsync(_options.Value, cancellationToken);
        
        try
        {
            await networkStream!.WriteAsync(data, cancellationToken);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error sending data: {ErrorMessage}", e.Message);
        }

        try
        {
            var buffer = new byte[1024];
            var read = await networkStream.ReadAsync(buffer, cancellationToken);

            if (read > 0)
            {
                _logger.LogInformation("Received response data: {Data}", Encoding.UTF8.GetString(buffer[..read]));
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error receiving response: {ErrorMessage}", e.Message);
        }
    }
}
