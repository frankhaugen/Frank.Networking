using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class InvitingReply : Reply
{
    public InvitingReply() : base(ReplyConstants.Inviting.Name, ReplyConstants.Inviting.Number, ReplyConstants.Inviting.Format)
    {
    }
}