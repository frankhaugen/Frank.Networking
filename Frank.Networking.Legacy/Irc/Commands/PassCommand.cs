using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class PassCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Pass;

    public PassCommand(string password) 
        : base(password)
    {
    }
    
    public string Password => Parameters[0];
}