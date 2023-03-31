using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class ListReply : Reply
{
    public ListReply() : base(ReplyConstants.List.Name, ReplyConstants.List.Number, ReplyConstants.List.Format)
    {
    }
}