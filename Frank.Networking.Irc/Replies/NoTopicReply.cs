using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class NoTopicReply : Reply
{
    public NoTopicReply() : base(ReplyConstants.Notopic.Name, ReplyConstants.Notopic.Number, ReplyConstants.Notopic.Format)
    {
    }
}