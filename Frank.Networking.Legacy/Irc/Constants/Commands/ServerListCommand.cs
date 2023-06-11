using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class ServerListCommand : Command
{
    public ServerListCommand() : base(CommandConstants.Servlist.Command, CommandConstants.Servlist.Helptext, CommandConstants.Servlist.Syntax)
    {
    }
}