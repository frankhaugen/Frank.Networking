using Frank.IRC.Commands.Base;

namespace Frank.Networking.Irc;

public class InviteCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Invite;

    public InviteCommand(string nickname, string channel) : base(nickname, channel)
    {
    }
    
    public string Nickname => Parameters[0];
    public string Channel => Parameters[1];
}