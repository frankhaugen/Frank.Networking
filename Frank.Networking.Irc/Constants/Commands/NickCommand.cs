using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class NickCommand : Command
{
    public NickCommand() : base(CommandConstants.Nick.Command, CommandConstants.Nick.Helptext, CommandConstants.Nick.Syntax)
    {
    }
}