using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class PingCommand : Command
{
    public PingCommand() : base(CommandConstants.Ping.Command, CommandConstants.Ping.Helptext, CommandConstants.Ping.Syntax)
    {
    }
}