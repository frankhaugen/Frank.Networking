using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class ListCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.List;

    public ListCommand(string channel, string server) : base(channel, server)
    {
    }
    
    public string Channel => Parameters[0];
    public string Server => Parameters[1];
}