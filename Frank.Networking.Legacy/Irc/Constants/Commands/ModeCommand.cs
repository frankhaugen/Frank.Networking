using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class ModeCommand : Command
{
    public ModeCommand() : base(CommandConstants.Mode.Command, CommandConstants.Mode.Helptext, CommandConstants.Mode.Syntax)
    {
    }
}