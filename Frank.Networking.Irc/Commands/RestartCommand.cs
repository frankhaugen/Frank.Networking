using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class RestartCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Restart;

    public RestartCommand() : base()
    {
    }
}