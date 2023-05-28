using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class UsersCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Users;

    public UsersCommand(string server) : base(server)
    {
    }
    
    public string Server => Parameters[0];
}