using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class ConnectCommand : Command
{
    public ConnectCommand() : base(CommandConstants.Connect.Command, CommandConstants.Connect.Helptext, CommandConstants.Connect.Syntax)
    {
    }
}