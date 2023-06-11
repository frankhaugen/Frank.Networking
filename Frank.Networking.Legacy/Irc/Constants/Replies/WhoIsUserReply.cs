using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoIsUserReply : Reply
{
    public WhoIsUserReply() : base(ReplyConstants.Whoisuser.Name, ReplyConstants.Whoisuser.Number, ReplyConstants.Whoisuser.Format)
    {
    }
}