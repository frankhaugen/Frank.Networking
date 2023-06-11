using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class PingCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Ping;

    public PingCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}