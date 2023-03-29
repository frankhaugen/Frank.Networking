using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class WhoCommand : Command
{
    public WhoCommand() : base(CommandConstants.Who.Command, CommandConstants.Who.Helptext, CommandConstants.Who.Syntax)
    {
    }
}