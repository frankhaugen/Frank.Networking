using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class InfoCommand : Command
{
    public InfoCommand() : base(CommandConstants.Info.Command, CommandConstants.Info.Helptext, CommandConstants.Info.Syntax)
    {
    }
}