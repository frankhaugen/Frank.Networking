using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfWhoIsReply : Reply
{
    public EndOfWhoIsReply() : base(ReplyConstants.Endofwhois.Name, ReplyConstants.Endofwhois.Number, ReplyConstants.Endofwhois.Format)
    {
    }
}