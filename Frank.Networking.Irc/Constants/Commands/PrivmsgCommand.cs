using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PrivmsgCommand : Command
{
    public PrivmsgCommand() : base(CommandConstants.PrivateMessage.Command, CommandConstants.PrivateMessage.Helptext, CommandConstants.PrivateMessage.Syntax)
    {
    }
}