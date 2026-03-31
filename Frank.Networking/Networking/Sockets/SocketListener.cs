using System.Net;
using System.Net.Sockets;
using System.Text;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.IRC.Networking.Sockets;

public class SocketListener : BackgroundService
{
    private readonly IOptions<SocketOptions> _options;
    private readonly ISocketMessageQueue _queue;
    private  Socket _socket;
    private readonly ILogger<SocketListener> _logger;

    public SocketListener(IOptions<SocketOptions> options, ISocketMessageQueue queue, ILogger<SocketListener> logger)
    {
        _options = options;
        _queue = queue;
        _logger = logger;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            await SetupAsync(stoppingToken);
        }
        catch (Exception e)
        {
            _logger.LogCritical(e, "Error receiving message, {ExceptionMessage}", e.Message);
        }
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                if (_socket.Poll(1000, SelectMode.SelectRead))
                {
                    var buffer = new byte[1024];
                    var bytesReceived = await _socket.ReceiveAsync(buffer, SocketFlags.None);
                    var message = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                    _queue.Enqueue(new SocketMessage { Message = message, Port = (int)_options.Value.Port });
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error receiving message, {ExceptionMessage}", e.Message);
            }
            finally
            {
                await Task.Delay(TimeSpan.FromMilliseconds(100), stoppingToken);
            }
        }
    }

    public async Task SetupAsync(CancellationToken cancellationToken)
    {
        _socket = new Socket(_options.Value.Type, _options.Value.Protocol);
        _socket.Bind(new IPEndPoint(IPAddress.Any, (int)_options.Value.Port));
        _socket.Listen(10);
        
        Task.Run(() => AcceptClientsAsync(cancellationToken), cancellationToken);
    }

    private async Task AcceptClientsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var socket = await _socket.AcceptAsync(cancellationToken);
                    _ = Task.Run(() => HandleClientAsync(socket, cancellationToken), cancellationToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error receiving message, {ExceptionMessage}", ex.Message);
                }
            }
        }

        private async Task HandleClientAsync(Socket socket, CancellationToken cancellationToken)
        {
            using (socket)
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = await socket.ReceiveAsync(buffer, SocketFlags.None);
                        if (bytesRead == 0) break; // Connection closed by client.

                        // Process the received data.
                        string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        _logger.LogDebug("Received data: {ReceivedData}", receivedData);

                        // Send a response to the client.
                        byte[] responseData = Encoding.UTF8.GetBytes($"Echo: {receivedData}");
                        await socket.SendAsync(responseData, SocketFlags.None);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error receiving message, {ExceptionMessage}", ex.Message);
                    }
                }
            }
        }
    
    public override void Dispose()
    {
        _socket.Dispose();
        base.Dispose();
    }
}