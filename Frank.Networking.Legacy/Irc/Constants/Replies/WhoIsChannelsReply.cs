using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoIsChannelsReply : Reply
{
    public WhoIsChannelsReply() : base(ReplyConstants.Whoischannels.Name, ReplyConstants.Whoischannels.Number, ReplyConstants.Whoischannels.Format)
    {
    }
}