using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

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