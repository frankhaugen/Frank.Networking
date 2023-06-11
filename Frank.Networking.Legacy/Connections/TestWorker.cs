using Microsoft.Extensions.Hosting;

namespace Frank.Networking.Legacy.Connections;

public class TestWorker : BackgroundService
{
    private readonly ILogger<TestWorker> _logger;
    private readonly SocketConnection<TestConfiguration, TestPort> _socketConnection;

    public TestWorker(ILogger<TestWorker> logger, SocketConnection<TestConfiguration, TestPort> socketConnection)
    {
        _logger = logger;
        _socketConnection = socketConnection;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await _socketConnection.ConnectAsync(stoppingToken);
        await _socketConnection.SendAsync(new byte[] { 0x01, 0x02, 0x03 }, stoppingToken);
    }
}