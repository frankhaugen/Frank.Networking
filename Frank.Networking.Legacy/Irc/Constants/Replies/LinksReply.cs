using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class LinksReply : Reply
{
    public LinksReply() : base(ReplyConstants.Links.Name, ReplyConstants.Links.Number, ReplyConstants.Links.Format)
    {
    }
}