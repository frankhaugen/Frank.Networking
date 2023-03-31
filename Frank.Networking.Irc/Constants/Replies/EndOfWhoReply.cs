using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfWhoReply : Reply
{
    public EndOfWhoReply() : base(ReplyConstants.Endofwho.Name, ReplyConstants.Endofwho.Number, ReplyConstants.Endofwho.Format)
    {
    }
}