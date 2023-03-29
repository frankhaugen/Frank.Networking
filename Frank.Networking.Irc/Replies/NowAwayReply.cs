using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class NowAwayReply : Reply
{
    public NowAwayReply() : base(ReplyConstants.Nowaway.Name, ReplyConstants.Nowaway.Number, ReplyConstants.Nowaway.Format)
    {
    }
}