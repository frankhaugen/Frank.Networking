using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WhoIsChannelsReply : Reply
{
    public WhoIsChannelsReply() : base(ReplyConstants.Whoischannels.Name, ReplyConstants.Whoischannels.Number, ReplyConstants.Whoischannels.Format)
    {
    }
}