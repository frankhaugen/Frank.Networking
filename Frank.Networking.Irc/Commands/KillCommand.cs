using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class KillCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Kill;

    public KillCommand(string user, string comment) : base(user, comment)
    {
    }
    
    public string User => Parameters[0];
    public string Comment => Parameters[1];
}