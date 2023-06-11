using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class NowAwayReply : Reply
{
    public NowAwayReply() : base(ReplyConstants.Nowaway.Name, ReplyConstants.Nowaway.Number, ReplyConstants.Nowaway.Format)
    {
    }
}