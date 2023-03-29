using Frank.IRC.Commands.Base;

namespace Frank.IRC.Commands;

public class InviteCommand : Command
{
    public InviteCommand() : base(CommandConstants.Invite.Command, CommandConstants.Invite.Helptext, CommandConstants.Invite.Syntax)
    {
    }
}