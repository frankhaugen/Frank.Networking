using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PrivmsgCommand : Command
{
    public PrivmsgCommand() : base(CommandConstants.PrivateMessage.Command, CommandConstants.PrivateMessage.Helptext, CommandConstants.PrivateMessage.Syntax)
    {
    }
}