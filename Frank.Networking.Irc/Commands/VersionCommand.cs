﻿using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class VersionCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Version;

    public VersionCommand(string server, string target) 
        : base(server, target)
    {
    }
    
    public string Server => Parameters[0];
    public string Target => Parameters[1];
}