using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class ServiceCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Service;

    public ServiceCommand(string nickname, string distribution, string type, string reserved, string info) 
        : base(nickname, distribution, type, reserved, info)
    {
    }
    
    public string Nickname => Parameters[0];
    public string Distribution => Parameters[1];
    public string Type => Parameters[2];
    public string Reserved => Parameters[3];
    public string Info => Parameters[4];
}