using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class SQueryCommand : Command
{
    public SQueryCommand() : base(CommandConstants.Squery.Command, CommandConstants.Squery.Helptext, CommandConstants.Squery.Syntax)
    {
    }
}