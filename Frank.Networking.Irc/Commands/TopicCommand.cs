﻿using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class TopicCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Topic;

    public TopicCommand(string channel, string topic) 
        : base(channel, topic)
    {
    }
    
    public string Channel => Parameters[0];
    public string Topic => Parameters[1];
}