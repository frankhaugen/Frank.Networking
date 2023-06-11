using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class NoTopicReply : Reply
{
    public NoTopicReply() : base(ReplyConstants.Notopic.Name, ReplyConstants.Notopic.Number, ReplyConstants.Notopic.Format)
    {
    }
}