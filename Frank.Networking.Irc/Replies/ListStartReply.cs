using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class ListStartReply : Reply
{
    public ListStartReply() : base(ReplyConstants.Liststart.Name, ReplyConstants.Liststart.Number, ReplyConstants.Liststart.Format)
    {
    }
}