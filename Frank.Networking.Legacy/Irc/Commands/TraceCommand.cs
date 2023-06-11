using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class TraceCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Trace;

    public TraceCommand(string server) 
        : base(server)
    {
    }
    
    public string Server => Parameters[0];
}