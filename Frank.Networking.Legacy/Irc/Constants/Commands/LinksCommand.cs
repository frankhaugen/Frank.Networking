using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class LinksCommand : Command
{
    public LinksCommand() : base(CommandConstants.Links.Command, CommandConstants.Links.Helptext, CommandConstants.Links.Syntax)
    {
    }
}