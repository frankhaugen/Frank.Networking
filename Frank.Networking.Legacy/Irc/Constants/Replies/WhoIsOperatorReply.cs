using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoIsOperatorReply : Reply
{
    public WhoIsOperatorReply() : base(ReplyConstants.Whoisoperator.Name, ReplyConstants.Whoisoperator.Number, ReplyConstants.Whoisoperator.Format)
    {
    }
}