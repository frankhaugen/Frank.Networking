using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class ServerCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Server;

    public ServerCommand(string servername, string hopcount, string info) 
        : base(servername, hopcount, info)
    {
    }
    
    public string Servername => Parameters[0];
    public int Hopcount => int.Parse(Parameters[1]);
    public string Info => Parameters[2];
}