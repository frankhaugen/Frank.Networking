using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class WhoCommand : Command
{
    public WhoCommand() : base(CommandConstants.Who.Command, CommandConstants.Who.Helptext, CommandConstants.Who.Syntax)
    {
    }
}