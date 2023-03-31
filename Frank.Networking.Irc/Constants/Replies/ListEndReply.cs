using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class ListEndReply : Reply
{
    public ListEndReply() : base(ReplyConstants.Listend.Name, ReplyConstants.Listend.Number, ReplyConstants.Listend.Format)
    {
    }
}