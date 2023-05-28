using Frank.IRC.Models;

using Microsoft.Extensions.Logging;

namespace Frank.IRC.CommandHandlers;

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