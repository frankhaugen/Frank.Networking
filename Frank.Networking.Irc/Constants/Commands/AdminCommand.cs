using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class AdminCommand : Command
{
    public AdminCommand() : base(CommandConstants.Admin.Command, CommandConstants.Admin.Helptext, CommandConstants.Admin.Syntax)
    {
    }
}