using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfWhoIsReply : Reply
{
    public EndOfWhoIsReply() : base(ReplyConstants.Endofwhois.Name, ReplyConstants.Endofwhois.Number, ReplyConstants.Endofwhois.Format)
    {
    }
}