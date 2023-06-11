using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class YourHostReply : Reply
{
    public YourHostReply() : base(ReplyConstants.Yourhost.Name, ReplyConstants.Yourhost.Number, ReplyConstants.Yourhost.Format)
    {
    }
}