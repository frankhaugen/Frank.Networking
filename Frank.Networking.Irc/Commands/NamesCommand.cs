using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class NamesCommand : Command
{
    public NamesCommand() : base(CommandConstants.Names.Command, CommandConstants.Names.Helptext, CommandConstants.Names.Syntax)
    {
    }
}