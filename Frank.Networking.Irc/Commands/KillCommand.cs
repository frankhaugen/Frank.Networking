using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class KillCommand : Command
{
    public KillCommand() : base(CommandConstants.Kill.Command, CommandConstants.Kill.Helptext, CommandConstants.Kill.Syntax)
    {
    }
}