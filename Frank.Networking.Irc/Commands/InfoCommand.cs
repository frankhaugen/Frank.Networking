using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class InfoCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Info;

    public InfoCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}