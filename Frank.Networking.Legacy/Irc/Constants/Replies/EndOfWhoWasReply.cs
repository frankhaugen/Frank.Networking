using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfWhoWasReply : Reply
{
    public EndOfWhoWasReply() : base(ReplyConstants.Endofwhowas.Name, ReplyConstants.Endofwhowas.Number, ReplyConstants.Endofwhowas.Format)
    {
    }
}