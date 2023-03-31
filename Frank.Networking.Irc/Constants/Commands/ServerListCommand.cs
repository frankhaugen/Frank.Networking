using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class ServerListCommand : Command
{
    public ServerListCommand() : base(CommandConstants.Servlist.Command, CommandConstants.Servlist.Helptext, CommandConstants.Servlist.Syntax)
    {
    }
}