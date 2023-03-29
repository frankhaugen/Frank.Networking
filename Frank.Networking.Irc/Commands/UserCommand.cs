using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class UserCommand : Command
{
    public UserCommand() : base(CommandConstants.User.Command, CommandConstants.User.Helptext, CommandConstants.User.Syntax)
    {
    }
}