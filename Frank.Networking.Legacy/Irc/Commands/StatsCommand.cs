using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

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