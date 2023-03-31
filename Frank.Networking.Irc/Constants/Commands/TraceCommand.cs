using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class TraceCommand : Command
{
    public TraceCommand() : base(CommandConstants.Trace.Command, CommandConstants.Trace.Helptext, CommandConstants.Trace.Syntax)
    {
    }
}