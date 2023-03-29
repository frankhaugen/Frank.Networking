using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class WelcomeReply : Reply
{
    public WelcomeReply() : base(ReplyConstants.Welcome.Name, ReplyConstants.Welcome.Number, ReplyConstants.Welcome.Format)
    {
    }
}