using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class NamesCommand : Command
{
    public NamesCommand() : base(CommandConstants.Names.Command, CommandConstants.Names.Helptext, CommandConstants.Names.Syntax)
    {
    }
}