using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class ConnectCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Connect;

    public ConnectCommand(string targetServer, string port, string remoteServer) : base(targetServer, port, remoteServer)
    {
    }
    
    public string TargetServer => Parameters[0];
    public string Port => Parameters[1];
    public string RemoteServer => Parameters[2];
}