using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class BounceReply : Reply
{
    public BounceReply() : base(ReplyConstants.Bounce.Name, ReplyConstants.Bounce.Number, ReplyConstants.Bounce.Format)
    {
    }
}