using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class StatsCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Stats;

    public StatsCommand(string query, string server) 
        : base(query, server)
    {
    }
    
    public string Query => Parameters[0];
    public string Server => Parameters[1];
}