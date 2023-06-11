using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class NickCommand : Command
{
    public NickCommand() : base(CommandConstants.Nick.Command, CommandConstants.Nick.Helptext, CommandConstants.Nick.Syntax)
    {
    }
}