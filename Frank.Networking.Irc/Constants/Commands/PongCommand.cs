using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PongCommand : Command
{
    public PongCommand() : base(CommandConstants.Pong.Command, CommandConstants.Pong.Helptext, CommandConstants.Pong.Syntax)
    {
    }
}