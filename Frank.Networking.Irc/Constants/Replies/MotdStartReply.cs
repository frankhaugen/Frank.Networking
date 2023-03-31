using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class MotdStartReply : Reply
{
    public MotdStartReply() : base(ReplyConstants.Motdstart.Name, ReplyConstants.Motdstart.Number, ReplyConstants.Motdstart.Format)
    {
    }
}