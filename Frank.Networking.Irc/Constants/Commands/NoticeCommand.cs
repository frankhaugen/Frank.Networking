using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class NoticeCommand : Command
{
    public NoticeCommand() : base(CommandConstants.Notice.Command, CommandConstants.Notice.Helptext, CommandConstants.Notice.Syntax)
    {
    }
}