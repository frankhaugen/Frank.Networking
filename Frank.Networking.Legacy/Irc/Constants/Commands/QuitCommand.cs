using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class QuitCommand : Command
{
    public QuitCommand() : base(CommandConstants.Quit.Command, CommandConstants.Quit.Helptext, CommandConstants.Quit.Syntax)
    {
    }
}