using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class UsersCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Users;

    public UsersCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}