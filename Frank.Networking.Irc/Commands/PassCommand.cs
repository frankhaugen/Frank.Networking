using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class PassCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Pass;

    public PassCommand(string password) 
        : base(password)
    {
    }
    
    public string Password => Parameters[0];
}