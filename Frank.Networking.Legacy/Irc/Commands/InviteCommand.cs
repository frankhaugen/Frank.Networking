using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Commands;

public class InviteCommand : IrcCommand
{
    public override IrcCommandName CommandName => IrcCommandName.Invite;

    public InviteCommand(string nickname, string channel) : base(nickname, channel)
    {
    }
    
    public string Nickname => Parameters[0];
    public string Channel => Parameters[1];
}