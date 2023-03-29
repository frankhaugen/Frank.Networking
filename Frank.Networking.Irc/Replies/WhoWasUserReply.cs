using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoWasUserReply : Reply
{
    public WhoWasUserReply() : base(ReplyConstants.Whowasuser.Name, ReplyConstants.Whowasuser.Number, ReplyConstants.Whowasuser.Format)
    {
    }
}