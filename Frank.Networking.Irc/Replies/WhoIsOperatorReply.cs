using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoIsOperatorReply : Reply
{
    public WhoIsOperatorReply() : base(ReplyConstants.Whoisoperator.Name, ReplyConstants.Whoisoperator.Number, ReplyConstants.Whoisoperator.Format)
    {
    }
}