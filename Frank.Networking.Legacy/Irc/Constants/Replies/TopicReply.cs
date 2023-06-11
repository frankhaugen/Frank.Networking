using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class TopicReply : Reply
{
    public TopicReply() : base(ReplyConstants.Topic.Name, ReplyConstants.Topic.Number, ReplyConstants.Topic.Format)
    {
    }
}