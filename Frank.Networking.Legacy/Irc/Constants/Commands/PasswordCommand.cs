using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PasswordCommand : Command
{
    public PasswordCommand() : base(CommandConstants.Password.Command, CommandConstants.Password.Helptext, CommandConstants.Password.Syntax)
    {
    }
}