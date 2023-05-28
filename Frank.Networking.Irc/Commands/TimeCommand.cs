using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class TimeCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Time;

    public TimeCommand(string server, string target) 
        : base(server, target)
    {
    }
    
    public string Server => Parameters[0];
    public string Target => Parameters[1];
}