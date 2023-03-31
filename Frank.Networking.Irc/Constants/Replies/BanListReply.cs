using Frank.IRC.Replies.Base;

namespace Frank.IRC.Replies;

public class BanListReply : Reply
{
    public BanListReply() : base(ReplyConstants.Banlist.Name, ReplyConstants.Banlist.Number, ReplyConstants.Banlist.Format)
    {
    }
}