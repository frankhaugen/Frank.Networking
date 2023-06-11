using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class UserHostCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Userhost;

    public UserHostCommand(string nickname) : base(nickname)
    {
    }
    
    public string Nickname => Parameters[0];
}