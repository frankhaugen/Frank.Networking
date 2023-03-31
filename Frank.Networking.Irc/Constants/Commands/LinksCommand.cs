using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class LinksCommand : Command
{
    public LinksCommand() : base(CommandConstants.Links.Command, CommandConstants.Links.Helptext, CommandConstants.Links.Syntax)
    {
    }
}