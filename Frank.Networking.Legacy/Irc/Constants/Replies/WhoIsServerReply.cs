using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class WhoIsServerReply : Reply
{
    public WhoIsServerReply() : base(ReplyConstants.Whoisserver.Name, ReplyConstants.Whoisserver.Number, ReplyConstants.Whoisserver.Format)
    {
    }
}