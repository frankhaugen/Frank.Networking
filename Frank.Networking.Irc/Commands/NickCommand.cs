using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class NickCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Nick;

    public NickCommand(string nickname) : base(nickname)
    {
    }
    
    public string Nickname => Parameters[0];
}