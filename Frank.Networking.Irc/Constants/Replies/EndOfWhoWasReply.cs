using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class EndOfWhoWasReply : Reply
{
    public EndOfWhoWasReply() : base(ReplyConstants.Endofwhowas.Name, ReplyConstants.Endofwhowas.Number, ReplyConstants.Endofwhowas.Format)
    {
    }
}