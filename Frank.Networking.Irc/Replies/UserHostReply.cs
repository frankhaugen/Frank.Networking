using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class UserHostReply : Reply
{
    public UserHostReply() : base(ReplyConstants.Userhost.Name, ReplyConstants.Userhost.Number, ReplyConstants.Userhost.Format)
    {
    }
}