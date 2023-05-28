using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class AdminCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Admin;

    public AdminCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}