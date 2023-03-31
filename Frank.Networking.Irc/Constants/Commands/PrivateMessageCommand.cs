using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PrivateMessageCommand : Command
{
    public PrivateMessageCommand() : base(CommandConstants.PrivateMessage.Command, CommandConstants.PrivateMessage.Helptext, CommandConstants.PrivateMessage.Syntax)
    {
    }
}