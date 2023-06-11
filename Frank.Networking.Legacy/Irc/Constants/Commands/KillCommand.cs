using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class KillCommand : Command
{
    public KillCommand() : base(CommandConstants.Kill.Command, CommandConstants.Kill.Helptext, CommandConstants.Kill.Syntax)
    {
    }
}