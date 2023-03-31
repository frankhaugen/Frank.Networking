using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class IsOnReply : Reply
{
    public IsOnReply() : base(ReplyConstants.Ison.Name, ReplyConstants.Ison.Number, ReplyConstants.Ison.Format)
    {
    }
}