using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class AwayReply : Reply
{
    public AwayReply() : base(ReplyConstants.Away.Name, ReplyConstants.Away.Number, ReplyConstants.Away.Format)
    {
    }
}