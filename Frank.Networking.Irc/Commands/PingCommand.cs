using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class PingCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Ping;

    public PingCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}