using Frank.Networking.Legacy.Irc.Constants.Commands.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Commands;

public class InviteCommand : Command
{
    public InviteCommand() : base(CommandConstants.Invite.Command, CommandConstants.Invite.Helptext, CommandConstants.Invite.Syntax)
    {
    }
}