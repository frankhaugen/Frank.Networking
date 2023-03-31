using Frank.IRC.Commands;
using Frank.IRC.Commands.Base;
using Frank.IRC.Models;
using Frank.IRC.Replies;

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