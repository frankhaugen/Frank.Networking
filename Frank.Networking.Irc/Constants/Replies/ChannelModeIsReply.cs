using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class ChannelModeIsReply : Reply
{
    public ChannelModeIsReply() : base(ReplyConstants.Channelmodeis.Name, ReplyConstants.Channelmodeis.Number, ReplyConstants.Channelmodeis.Format)
    {
    }
}