using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoIsUserReply : Reply
{
    public WhoIsUserReply() : base(ReplyConstants.Whoisuser.Name, ReplyConstants.Whoisuser.Number, ReplyConstants.Whoisuser.Format)
    {
    }
}