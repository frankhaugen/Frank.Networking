using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class ListStartReply : Reply
{
    public ListStartReply() : base(ReplyConstants.Liststart.Name, ReplyConstants.Liststart.Number, ReplyConstants.Liststart.Format)
    {
    }
}