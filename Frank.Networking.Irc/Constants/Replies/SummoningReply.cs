using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class SummoningReply : Reply
{
    public SummoningReply() : base(ReplyConstants.Summoning.Name, ReplyConstants.Summoning.Number, ReplyConstants.Summoning.Format)
    {
    }
}