using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoIsIdleReply : Reply
{
    public WhoIsIdleReply() : base(ReplyConstants.Whoisidle.Name, ReplyConstants.Whoisidle.Number, ReplyConstants.Whoisidle.Format)
    {
    }
}