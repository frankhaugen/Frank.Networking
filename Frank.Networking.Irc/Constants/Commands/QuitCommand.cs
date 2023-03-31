using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class QuitCommand : Command
{
    public QuitCommand() : base(CommandConstants.Quit.Command, CommandConstants.Quit.Helptext, CommandConstants.Quit.Syntax)
    {
    }
}