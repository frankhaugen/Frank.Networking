using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class CreatedReply : Reply
{
    public CreatedReply() : base(ReplyConstants.Created.Name, ReplyConstants.Created.Number, ReplyConstants.Created.Format)
    {
    }
}