using Frank.Networking.Legacy.Irc.Constants.Replies.Base;

namespace Frank.Networking.Legacy.Irc.Constants.Replies;

public class EndOfBanListReply : Reply
{
    public EndOfBanListReply() : base(ReplyConstants.Endofbanlist.Name, ReplyConstants.Endofbanlist.Number, ReplyConstants.Endofbanlist.Format)
    {
    }
}