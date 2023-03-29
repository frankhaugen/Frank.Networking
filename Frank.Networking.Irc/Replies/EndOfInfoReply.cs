using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfInfoReply : Reply
{
    public EndOfInfoReply() : base(ReplyConstants.Endofinfo.Name, ReplyConstants.Endofinfo.Number, ReplyConstants.Endofinfo.Format)
    {
    }
}