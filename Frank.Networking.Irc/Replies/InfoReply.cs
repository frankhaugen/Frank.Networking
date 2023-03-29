using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class InfoReply : Reply
{
    public InfoReply() : base(ReplyConstants.Info.Name, ReplyConstants.Info.Number, ReplyConstants.Info.Format)
    {
    }
}