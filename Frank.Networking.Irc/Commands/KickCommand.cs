using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class KickCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Kick;

    public KickCommand(string channel, string user, string comment) : base(channel, user, comment)
    {
    }
    
    public string Channel => Parameters[0];
    public string User => Parameters[1];
    public string Comment => Parameters[2];
}