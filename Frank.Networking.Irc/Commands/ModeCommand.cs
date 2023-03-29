using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class ModeCommand : Command
{
    public ModeCommand() : base(CommandConstants.Mode.Command, CommandConstants.Mode.Helptext, CommandConstants.Mode.Syntax)
    {
    }
}