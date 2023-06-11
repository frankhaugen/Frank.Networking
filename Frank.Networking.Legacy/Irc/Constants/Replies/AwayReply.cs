using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class AwayReply : Reply
{
    public AwayReply() : base(ReplyConstants.Away.Name, ReplyConstants.Away.Number, ReplyConstants.Away.Format)
    {
    }
}