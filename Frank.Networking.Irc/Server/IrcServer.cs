﻿using Microsoft.Extensions.Logging;

namespace Frank.Networking.Irc.Server;

public class IrcServer : IIrcServer
{
    private readonly ILogger<IrcServer> _logger;

    public IrcServer(ILogger<IrcServer> logger)
    {
        _logger = logger;
    }

    public async Task ReceiveCommandAsync(IIrcCommand command)
    {
        _logger.LogInformation("Received command {CommandName}", command.CommandName);
    }
}