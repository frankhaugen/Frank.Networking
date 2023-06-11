using System.Text;

using Frank.Networking.Client;

namespace Frank.Networking.Sample;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly INetworkClient _networkClient;

    public Worker(ILogger<Worker> logger, INetworkClient networkClient)
    {
        _logger = logger;
        _networkClient = networkClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // _logger.LogInformation("Sending message at: {Time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
            
            await _networkClient.SendAsync("Hello, World!"u8.ToArray(), stoppingToken);
        }
    }
}