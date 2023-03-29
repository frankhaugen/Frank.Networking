using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class TimeCommand : Command
{
    public TimeCommand() : base(CommandConstants.Time.Command, CommandConstants.Time.Helptext, CommandConstants.Time.Syntax)
    {
    }
}