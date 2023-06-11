using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class NickCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Nick;

    public NickCommand(string nickname) : base(nickname)
    {
    }
    
    public string Nickname => Parameters[0];
}