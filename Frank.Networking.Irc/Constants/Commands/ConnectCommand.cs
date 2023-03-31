using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class ConnectCommand : Command
{
    public ConnectCommand() : base(CommandConstants.Connect.Command, CommandConstants.Connect.Helptext, CommandConstants.Connect.Syntax)
    {
    }
}