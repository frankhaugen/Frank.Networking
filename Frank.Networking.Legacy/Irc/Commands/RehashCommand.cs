using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class RehashCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Rehash;

    public RehashCommand() : base()
    {
    }
}