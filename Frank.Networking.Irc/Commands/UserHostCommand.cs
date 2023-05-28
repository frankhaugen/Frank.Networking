using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class UserHostCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Userhost;

    public UserHostCommand(string nickname) : base(nickname)
    {
    }
    
    public string Nickname => Parameters[0];
}