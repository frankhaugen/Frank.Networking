using Microsoft.Extensions.Hosting;

namespace Frank.Networking.Irc.Server;


public interface IIrcServer : IHostedService
{
    
}

public class IrcServer : IIrcServer
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var strem = new MemoryStream();
        
        
        await Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}