using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class ServerListCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Servlist;

    public ServerListCommand(string mask, string type) 
        : base(mask, type)
    {
    }
    
    public string Mask => Parameters[0];
    public string Type => Parameters[1];
}