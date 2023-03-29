using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class KickCommand : Command
{
    public KickCommand() : base(CommandConstants.Kick.Command, CommandConstants.Kick.Helptext, CommandConstants.Kick.Syntax)
    {
    }
}