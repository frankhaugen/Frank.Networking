using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class NoticeCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Notice;

    public NoticeCommand(string target, string message) : base(target, message)
    {
    }
    
    public string Target => Parameters[0];
    public string Message => Parameters[1];
}