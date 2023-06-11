using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class DieCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Die;

    public DieCommand()
    {
    }
}