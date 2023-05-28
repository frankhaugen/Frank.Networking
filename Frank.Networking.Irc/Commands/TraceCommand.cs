using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class TraceCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Trace;

    public TraceCommand(string server) 
        : base(server)
    {
    }
    
    public string Server => Parameters[0];
}