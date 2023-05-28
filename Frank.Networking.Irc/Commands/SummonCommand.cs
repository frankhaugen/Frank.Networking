using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class SummonCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Summon;

    public SummonCommand(string user, string server) 
        : base(user, server)
    {
    }
    
    public string User => Parameters[0];
    public string Server => Parameters[1];
}