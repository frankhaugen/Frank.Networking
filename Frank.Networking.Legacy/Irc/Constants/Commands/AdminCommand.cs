using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class AdminCommand : Command
{
    public AdminCommand() : base(CommandConstants.Admin.Command, CommandConstants.Admin.Helptext, CommandConstants.Admin.Syntax)
    {
    }
}