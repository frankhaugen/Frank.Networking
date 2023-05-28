using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class JoinCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Join;

    public JoinCommand(string channel) : base(channel)
    {
    }
    
    public string Channel => Parameters[0];
}