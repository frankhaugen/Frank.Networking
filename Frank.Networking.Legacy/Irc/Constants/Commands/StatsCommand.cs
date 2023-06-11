using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class StatsCommand : Command
{
    public StatsCommand() : base(CommandConstants.Stats.Command, CommandConstants.Stats.Helptext, CommandConstants.Stats.Syntax)
    {
    }
}