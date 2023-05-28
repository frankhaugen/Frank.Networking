using System.Text;

using Frank.Networking.Irc;

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
            var ircMessage = new JoinCommand("#test");
            var data = Encoding.UTF8.GetBytes(ircMessage.ToString());
            await _client.SendAsync(data);
        }
    }
}