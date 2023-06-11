using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfLinksReply : Reply
{
    public EndOfLinksReply() : base(ReplyConstants.Endoflinks.Name, ReplyConstants.Endoflinks.Number, ReplyConstants.Endoflinks.Format)
    {
    }
}