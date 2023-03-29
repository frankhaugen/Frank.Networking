using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfLinksReply : Reply
{
    public EndOfLinksReply() : base(ReplyConstants.Endoflinks.Name, ReplyConstants.Endoflinks.Number, ReplyConstants.Endoflinks.Format)
    {
    }
}