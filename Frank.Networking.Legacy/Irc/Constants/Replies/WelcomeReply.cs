using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WelcomeReply : Reply
{
    public WelcomeReply() : base(ReplyConstants.Welcome.Name, ReplyConstants.Welcome.Number, ReplyConstants.Welcome.Format)
    {
    }
}