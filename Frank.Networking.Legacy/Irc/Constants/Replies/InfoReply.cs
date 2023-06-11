using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class InfoReply : Reply
{
    public InfoReply() : base(ReplyConstants.Info.Name, ReplyConstants.Info.Number, ReplyConstants.Info.Format)
    {
    }
}