using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class RehashCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Rehash;

    public RehashCommand() : base()
    {
    }
}