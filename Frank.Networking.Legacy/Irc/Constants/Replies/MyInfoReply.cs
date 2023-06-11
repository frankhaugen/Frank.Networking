using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class MyInfoReply : Reply
{
    public MyInfoReply() : base(ReplyConstants.Myinfo.Name, ReplyConstants.Myinfo.Number, ReplyConstants.Myinfo.Format)
    {
    }
}