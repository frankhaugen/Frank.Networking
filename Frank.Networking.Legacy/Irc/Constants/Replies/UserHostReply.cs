using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class UserHostReply : Reply
{
    public UserHostReply() : base(ReplyConstants.Userhost.Name, ReplyConstants.Userhost.Number, ReplyConstants.Userhost.Format)
    {
    }
}