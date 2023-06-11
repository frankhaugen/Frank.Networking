using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class IsOnReply : Reply
{
    public IsOnReply() : base(ReplyConstants.Ison.Name, ReplyConstants.Ison.Number, ReplyConstants.Ison.Format)
    {
    }
}