using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class ChannelModeIsReply : Reply
{
    public ChannelModeIsReply() : base(ReplyConstants.Channelmodeis.Name, ReplyConstants.Channelmodeis.Number, ReplyConstants.Channelmodeis.Format)
    {
    }
}