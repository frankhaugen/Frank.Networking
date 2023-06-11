using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class TraceCommand : Command
{
    public TraceCommand() : base(CommandConstants.Trace.Command, CommandConstants.Trace.Helptext, CommandConstants.Trace.Syntax)
    {
    }
}