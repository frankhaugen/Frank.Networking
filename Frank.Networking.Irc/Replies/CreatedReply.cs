using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class CreatedReply : Reply
{
    public CreatedReply() : base(ReplyConstants.Created.Name, ReplyConstants.Created.Number, ReplyConstants.Created.Format)
    {
    }
}