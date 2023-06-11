using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class ListReply : Reply
{
    public ListReply() : base(ReplyConstants.List.Name, ReplyConstants.List.Number, ReplyConstants.List.Format)
    {
    }
}