using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoIsServerReply : Reply
{
    public WhoIsServerReply() : base(ReplyConstants.Whoisserver.Name, ReplyConstants.Whoisserver.Number, ReplyConstants.Whoisserver.Format)
    {
    }
}