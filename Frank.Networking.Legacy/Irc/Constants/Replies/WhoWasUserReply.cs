using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoWasUserReply : Reply
{
    public WhoWasUserReply() : base(ReplyConstants.Whowasuser.Name, ReplyConstants.Whowasuser.Number, ReplyConstants.Whowasuser.Format)
    {
    }
}