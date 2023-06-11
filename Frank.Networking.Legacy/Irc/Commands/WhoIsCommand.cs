using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

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