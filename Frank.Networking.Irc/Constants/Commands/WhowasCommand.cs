using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class WhowasCommand : Command
{
    public WhowasCommand() : base(CommandConstants.Whowas.Command, CommandConstants.Whowas.Helptext, CommandConstants.Whowas.Syntax)
    {
    }
}