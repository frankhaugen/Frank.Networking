using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PrivateMessageCommand : Command
{
    public PrivateMessageCommand() : base(CommandConstants.PrivateMessage.Command, CommandConstants.PrivateMessage.Helptext, CommandConstants.PrivateMessage.Syntax)
    {
    }
}