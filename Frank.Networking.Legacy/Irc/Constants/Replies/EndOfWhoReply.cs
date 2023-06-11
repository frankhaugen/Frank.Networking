using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfWhoReply : Reply
{
    public EndOfWhoReply() : base(ReplyConstants.Endofwho.Name, ReplyConstants.Endofwho.Number, ReplyConstants.Endofwho.Format)
    {
    }
}