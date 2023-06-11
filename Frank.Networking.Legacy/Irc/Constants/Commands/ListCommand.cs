using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class ListCommand : Command
{
    public ListCommand() : base(CommandConstants.List.Command, CommandConstants.List.Helptext, CommandConstants.List.Syntax)
    {
    }
}