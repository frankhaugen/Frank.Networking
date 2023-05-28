using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class WhoIsCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Whois;

    public WhoIsCommand(string mask, string server) 
        : base(mask, server)
    {
    }
    
    public string Mask => Parameters[0];
    public string Server => Parameters[1];
}