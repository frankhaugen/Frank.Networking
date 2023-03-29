using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class StatsCommand : Command
{
    public StatsCommand() : base(CommandConstants.Stats.Command, CommandConstants.Stats.Helptext, CommandConstants.Stats.Syntax)
    {
    }
}