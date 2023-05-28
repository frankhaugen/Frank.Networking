using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class ErrorCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Error;

    public ErrorCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}