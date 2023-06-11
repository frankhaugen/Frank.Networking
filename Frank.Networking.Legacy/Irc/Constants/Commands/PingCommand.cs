using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class PingCommand : Command
{
    public PingCommand() : base(CommandConstants.Ping.Command, CommandConstants.Ping.Helptext, CommandConstants.Ping.Syntax)
    {
    }
}