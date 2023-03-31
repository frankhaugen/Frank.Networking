using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class MyInfoReply : Reply
{
    public MyInfoReply() : base(ReplyConstants.Myinfo.Name, ReplyConstants.Myinfo.Number, ReplyConstants.Myinfo.Format)
    {
    }
}