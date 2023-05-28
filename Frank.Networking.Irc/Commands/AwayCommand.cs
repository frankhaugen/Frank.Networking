using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class AwayCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Away;

    public AwayCommand(string message) : base(message)
    {
    }
    
    public string Message => Parameters[0];
}