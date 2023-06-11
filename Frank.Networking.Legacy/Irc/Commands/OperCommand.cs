using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

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