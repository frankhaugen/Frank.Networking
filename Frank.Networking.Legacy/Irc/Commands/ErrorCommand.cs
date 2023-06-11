using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class ErrorCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Error;

    public ErrorCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}