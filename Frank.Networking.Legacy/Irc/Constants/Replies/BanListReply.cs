using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class BanListReply : Reply
{
    public BanListReply() : base(ReplyConstants.Banlist.Name, ReplyConstants.Banlist.Number, ReplyConstants.Banlist.Format)
    {
    }
}