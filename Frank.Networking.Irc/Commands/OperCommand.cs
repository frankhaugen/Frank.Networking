using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class OperCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Oper;

    public OperCommand(string user, string password) 
        : base(user, password)
    {
    }
    
    public string User => Parameters[0];
    public string Password => Parameters[1];
}