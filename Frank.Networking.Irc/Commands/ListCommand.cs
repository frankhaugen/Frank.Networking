using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class ListCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.List;

    public ListCommand(string channel, string server) : base(channel, server)
    {
    }
    
    public string Channel => Parameters[0];
    public string Server => Parameters[1];
}