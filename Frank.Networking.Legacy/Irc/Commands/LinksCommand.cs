using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class LinksCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Links;

    public LinksCommand(string remoteServer, string serverMask) : base(remoteServer, serverMask)
    {
    }
    
    public string RemoteServer => Parameters[0];
    public string ServerMask => Parameters[1];
}