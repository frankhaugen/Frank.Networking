using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class InfoCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Info;

    public InfoCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}