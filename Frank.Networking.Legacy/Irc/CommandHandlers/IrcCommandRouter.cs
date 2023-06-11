using Frank.Networking.Legacy.Irc.Models;

namespace Frank.Networking.Legacy.Irc.CommandHandlers;

public class IrcCommandRouter : IIrcCommandRouter
{
    private readonly ILogger<IrcCommandRouter> _logger;

    public IrcCommandRouter(ILogger<IrcCommandRouter> logger)
    {
        _logger = logger;
    }

    public async Task RouteAsync(IrcMessage message)
    {
        
    }
}