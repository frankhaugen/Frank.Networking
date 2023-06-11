using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class RestartCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Restart;

    public RestartCommand() : base()
    {
    }
}