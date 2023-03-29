using Microsoft.Extensions.Hosting;

namespace Frank.Networking.Legacy;

public class SocketEnventsOrchestrator : BackgroundService
{
    private readonly ISocketConnectionManager _connectionManager;
    private readonly SocketEvents _socketEvents;
    
    public SocketEnventsOrchestrator(ISocketConnectionManager connectionManager, SocketEvents socketEvents)
    {
        _connectionManager = connectionManager;
        _socketEvents = socketEvents;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        
        while (!stoppingToken.IsCancellationRequested)
        {
            foreach (var connection in _connectionManager.GetAll())
            {
                try
                {
                    var data = await connection.ReceiveAsync(stoppingToken);
                    _socketEvents.OnReceived(connection);
                    await connection.SendAsync(data, stoppingToken);
                    _socketEvents.OnSent(connection);
                }
                catch (Exception)
                {
                    _socketEvents.OnConnectionError(connection);
                }
            }
        }
    }
}