using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class InfoCommand : Command
{
    public InfoCommand() : base(CommandConstants.Info.Command, CommandConstants.Info.Helptext, CommandConstants.Info.Syntax)
    {
    }
}