using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class NoticeCommand : Command
{
    public NoticeCommand() : base(CommandConstants.Notice.Command, CommandConstants.Notice.Helptext, CommandConstants.Notice.Syntax)
    {
    }
}