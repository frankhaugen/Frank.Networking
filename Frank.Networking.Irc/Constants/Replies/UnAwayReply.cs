using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class UnAwayReply : Reply
{
    public UnAwayReply() : base(ReplyConstants.Unaway.Name, ReplyConstants.Unaway.Number, ReplyConstants.Unaway.Format)
    {
    }
}