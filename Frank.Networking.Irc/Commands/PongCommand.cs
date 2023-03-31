using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class PongCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Pong;

    public PongCommand(string message) : base(message)
    {
    }
}