using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class AwayCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Away;

    public AwayCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}