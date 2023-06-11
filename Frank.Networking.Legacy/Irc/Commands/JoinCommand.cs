using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class JoinCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Join;

    public JoinCommand(string channel) : base(channel)
    {
    }
    
    public string Channel => Parameters[0];
}