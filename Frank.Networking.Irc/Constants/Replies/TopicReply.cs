using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class TopicReply : Reply
{
    public TopicReply() : base(ReplyConstants.Topic.Name, ReplyConstants.Topic.Number, ReplyConstants.Topic.Format)
    {
    }
}