using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class PongCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Pong;

    public PongCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}