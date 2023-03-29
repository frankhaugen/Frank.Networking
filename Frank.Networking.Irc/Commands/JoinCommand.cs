using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class JoinCommand : Command
{
    public JoinCommand() : base(CommandConstants.Join.Command, CommandConstants.Join.Helptext, CommandConstants.Join.Syntax)
    {
    }
}