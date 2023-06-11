using System.Net;
using System.Net.Sockets;

using Frank.Networking.Common;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Networking.Server;

public class NetworkServer : BackgroundService
{
    private readonly ILogger<NetworkServer> _logger;
    private readonly IOnDataReceivedHandler _serverDataReceivedHandler;
    private readonly IOptions<NetworkServerConfiguration> _options;

    public NetworkServer(ILogger<NetworkServer> logger, IOnDataReceivedHandler serverDataReceivedHandler, IOptions<NetworkServerConfiguration> options)
    {
        _logger = logger;
        _serverDataReceivedHandler = serverDataReceivedHandler;
        _options = options;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var listenSocket = NetworkConnectionFactory.CreateListeningBoundSocket(_options.Value);

        while (!stoppingToken.IsCancellationRequested)
        {
            // Wait for a new connection to arrive
            var connection = await listenSocket.AcceptAsync(stoppingToken);
            
            try
            {
                // Spin up a new task to handle the connection
                await Task.Run(ListenAsync(connection, stoppingToken), stoppingToken);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error while listening for connections on {@LocalEndPoint} to {@RemoteEndPoint} with {ErrorMessage}", connection.LocalEndPoint, connection.RemoteEndPoint, e.Message);
            }
        }
    }

    private Func<Task?> ListenAsync(Socket connection, CancellationToken stoppingToken) =>
        async () =>
        {
            var buffer = new byte[_options.Value.BufferSize];
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    var read = await connection.ReceiveAsync(buffer, SocketFlags.None);
                    if (read == 0)
                        break;
                    await _serverDataReceivedHandler.OnDataReceivedAsync(buffer.AsMemory(), stoppingToken);
                }
            }
            finally
            {
                connection.Dispose();
            }
        };
}