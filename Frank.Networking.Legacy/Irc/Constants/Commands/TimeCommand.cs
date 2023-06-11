using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class TimeCommand : Command
{
    public TimeCommand() : base(CommandConstants.Time.Command, CommandConstants.Time.Helptext, CommandConstants.Time.Syntax)
    {
    }
}