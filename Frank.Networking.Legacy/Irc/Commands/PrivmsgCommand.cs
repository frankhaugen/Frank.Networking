using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class PrivmsgCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Privmsg;

    public PrivmsgCommand(string target, string message) : base(target, message)
    {
    }
    
    public string Target => Parameters[0];
    public string Message => Parameters[1];
}