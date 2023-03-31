using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoReply : Reply
{
    public WhoReply() : base(ReplyConstants.Whoisuser.Name, ReplyConstants.Whoisuser.Number, ReplyConstants.Whoisuser.Format)
    {
    }
}