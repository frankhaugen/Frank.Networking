using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class YourHostReply : Reply
{
    public YourHostReply() : base(ReplyConstants.Yourhost.Name, ReplyConstants.Yourhost.Number, ReplyConstants.Yourhost.Format)
    {
    }
}