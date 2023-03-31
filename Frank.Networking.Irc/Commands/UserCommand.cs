using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class UserCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.User;

    public UserCommand(string username, string hostname, string servername, string realname) 
        : base(username, hostname, servername, realname)
    {
    }
}