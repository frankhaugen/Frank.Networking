using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class MotdStartReply : Reply
{
    public MotdStartReply() : base(ReplyConstants.Motdstart.Name, ReplyConstants.Motdstart.Number, ReplyConstants.Motdstart.Format)
    {
    }
}