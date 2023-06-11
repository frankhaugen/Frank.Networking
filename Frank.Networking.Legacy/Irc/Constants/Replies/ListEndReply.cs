using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class ListEndReply : Reply
{
    public ListEndReply() : base(ReplyConstants.Listend.Name, ReplyConstants.Listend.Number, ReplyConstants.Listend.Format)
    {
    }
}