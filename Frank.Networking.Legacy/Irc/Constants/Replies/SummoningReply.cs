using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class SummoningReply : Reply
{
    public SummoningReply() : base(ReplyConstants.Summoning.Name, ReplyConstants.Summoning.Number, ReplyConstants.Summoning.Format)
    {
    }
}