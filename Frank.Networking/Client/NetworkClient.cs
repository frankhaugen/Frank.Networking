using System.Net;
using System.Net.Sockets;

using Frank.Networking.Common;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking.Client;

public class NetworkClient : INetworkClient
{
    private readonly ILogger<NetworkClient> _logger;
    private readonly IOptions<NetworkClientConfiguration> _options;
    
    private NetworkStream? _networkStream;

    public NetworkClient(IOptions<NetworkClientConfiguration> options, ILogger<NetworkClient> logger)
    {
        _options = options;
        _logger = logger;
    }

    public async Task SendAsync(ReadOnlyMemory<Byte> data, CancellationToken cancellationToken)
    {
        _networkStream ??= await NetworkConnectionFactory.CreateConnectedNetworkStreamAsync(_options.Value, cancellationToken);
        await _networkStream!.WriteAsync(data, cancellationToken);
    }
}