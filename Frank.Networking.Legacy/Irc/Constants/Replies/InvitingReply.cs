using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class InvitingReply : Reply
{
    public InvitingReply() : base(ReplyConstants.Inviting.Name, ReplyConstants.Inviting.Number, ReplyConstants.Inviting.Format)
    {
    }
}