using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class KickCommand : Command
{
    public KickCommand() : base(CommandConstants.Kick.Command, CommandConstants.Kick.Helptext, CommandConstants.Kick.Syntax)
    {
    }
}