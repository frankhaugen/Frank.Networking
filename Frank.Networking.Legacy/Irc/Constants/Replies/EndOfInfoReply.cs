using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfInfoReply : Reply
{
    public EndOfInfoReply() : base(ReplyConstants.Endofinfo.Name, ReplyConstants.Endofinfo.Number, ReplyConstants.Endofinfo.Format)
    {
    }
}