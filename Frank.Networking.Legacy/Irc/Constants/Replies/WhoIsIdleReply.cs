using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoIsIdleReply : Reply
{
    public WhoIsIdleReply() : base(ReplyConstants.Whoisidle.Name, ReplyConstants.Whoisidle.Number, ReplyConstants.Whoisidle.Format)
    {
    }
}