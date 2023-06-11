using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class UnAwayReply : Reply
{
    public UnAwayReply() : base(ReplyConstants.Unaway.Name, ReplyConstants.Unaway.Number, ReplyConstants.Unaway.Format)
    {
    }
}