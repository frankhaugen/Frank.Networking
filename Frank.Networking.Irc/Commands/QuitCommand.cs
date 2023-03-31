using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class QuitCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Quit;

    public QuitCommand(string message) : base(message)
    {
    }
}