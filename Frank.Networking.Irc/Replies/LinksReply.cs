using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class LinksReply : Reply
{
    public LinksReply() : base(ReplyConstants.Links.Name, ReplyConstants.Links.Number, ReplyConstants.Links.Format)
    {
    }
}