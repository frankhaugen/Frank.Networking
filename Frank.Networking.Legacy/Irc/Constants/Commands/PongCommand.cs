using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PongCommand : Command
{
    public PongCommand() : base(CommandConstants.Pong.Command, CommandConstants.Pong.Helptext, CommandConstants.Pong.Syntax)
    {
    }
}