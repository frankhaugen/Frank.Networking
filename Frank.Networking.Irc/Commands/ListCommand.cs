using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class ListCommand : Command
{
    public ListCommand() : base(CommandConstants.List.Command, CommandConstants.List.Helptext, CommandConstants.List.Syntax)
    {
    }
}