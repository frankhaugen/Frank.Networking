using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class NamesCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Names;

    public NamesCommand(string channel, string target) : base(channel, target)
    {
    }
    
    public string Channel => Parameters[0];
    public string Target => Parameters[1];
}