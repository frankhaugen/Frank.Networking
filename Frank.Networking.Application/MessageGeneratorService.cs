using System.Text;

namespace Frank.Networking.Application;

public class MessageGeneratorService : BackgroundService
{
    private readonly ISocketSender _client;

    public MessageGeneratorService(ISocketSender client)
    {
        _client = client;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            var data = Encoding.UTF8.GetBytes("My message");
            await _client.SendAsync(data);
        }
    }
}