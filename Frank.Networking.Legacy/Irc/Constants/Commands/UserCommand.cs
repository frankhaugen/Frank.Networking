using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class UserCommand : Command
{
    public UserCommand() : base(CommandConstants.User.Command, CommandConstants.User.Helptext, CommandConstants.User.Syntax)
    {
    }
}