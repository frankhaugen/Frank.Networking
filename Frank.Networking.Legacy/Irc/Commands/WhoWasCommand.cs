﻿using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class WhoWasCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Whowas;

    public WhoWasCommand(string nickname, string count, string server) 
        : base(nickname, count, server)
    {
    }
    
    public string Nickname => Parameters[0];
    public string Count => Parameters[1];
    public string Server => Parameters[2];
}