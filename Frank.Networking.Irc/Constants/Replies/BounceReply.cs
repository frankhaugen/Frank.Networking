using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class BounceReply : Reply
{
    public BounceReply() : base(ReplyConstants.Bounce.Name, ReplyConstants.Bounce.Number, ReplyConstants.Bounce.Format)
    {
    }
}