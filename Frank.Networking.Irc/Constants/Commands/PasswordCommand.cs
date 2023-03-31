using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PasswordCommand : Command
{
    public PasswordCommand() : base(CommandConstants.Password.Command, CommandConstants.Password.Helptext, CommandConstants.Password.Syntax)
    {
    }
}