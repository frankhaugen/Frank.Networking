using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

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