using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class UserCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.User;

    public UserCommand(string username, string hostname, string servername, string realname) 
        : base(username, hostname, servername, realname)
    {
    }
    
    public string Username => Parameters[0];
    public string Hostname => Parameters[1];
    public string Servername => Parameters[2];
    public string Realname => Parameters[3];
}