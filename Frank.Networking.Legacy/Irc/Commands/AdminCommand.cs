using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class AdminCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Admin;

    public AdminCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}