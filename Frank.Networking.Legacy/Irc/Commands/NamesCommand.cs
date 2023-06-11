using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class NamesCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Names;

    public NamesCommand(string channel, string target) : base(channel, target)
    {
    }
    
    public string Channel => Parameters[0];
    public string Target => Parameters[1];
}