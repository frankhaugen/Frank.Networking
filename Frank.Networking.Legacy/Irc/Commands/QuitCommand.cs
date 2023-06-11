using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class QuitCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Quit;

    public QuitCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}