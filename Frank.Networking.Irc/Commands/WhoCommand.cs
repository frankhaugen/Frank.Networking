using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class WhoCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Who;

    public WhoCommand(string name, string o) 
        : base(name, o)
    {
    }
    
    public string Name => Parameters[0];
    public string O => Parameters[1];
}