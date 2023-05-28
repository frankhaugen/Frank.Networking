using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class DieCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Die;

    public DieCommand()
    {
    }
}